using MasterPageTest.DTO;
using MasterPageTest.Models;
using MasterPageTest.Models.NonCommon;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MasterPageTest.Services
{
    public class TariffService: ITariffService
    {
        private readonly EmrDbContext _context;

        public TariffService(EmrDbContext context)
        {
            _context = context;
        }

        public async Task<TariffDto> GetTariffAsync(TariffRequest req)
        {
            ValidateGetTariff("GetTariff", req);

            var tariff = new TariffDto();

            var regEntity = await _context.Registrations
                .FirstOrDefaultAsync(x => x.RegistrationNo == req.RegistrationNo);

            if (!req.IsRecalculation || (req.IsRecalculation && string.IsNullOrEmpty(req.CoveredClassCode)))
            {
                req.ChargeClassCode = regEntity.ChargeClassCode;
                req.BusinessPartnerId = regEntity.BusinessPartnerId;
                req.DocumentNo = regEntity.CustomerDocumentNo;
                req.CoveredClassCode = regEntity.CoveredClassCode ?? req.ChargeClassCode;
            }

            var classEntity = await _context.Classes
                .FirstOrDefaultAsync(x => x.ClassCode == req.ChargeClassCode);

            var costEntity = await _context.ItemCosts
                .FirstOrDefaultAsync(x => x.SiteCode == regEntity.SiteCode && x.ItemId == req.ItemId);

            if (costEntity != null)
            {
                tariff.CostPrice = (costEntity.Material ?? 0)
                         + (costEntity.Labor ?? 0)
                         + (costEntity.Overhead ?? 0)
                         + (costEntity.SubContract ?? 0)
                         + (costEntity.Burden ?? 0);

                tariff.LaborCost = (costEntity.Labor ?? 0);
            }

            var parUseRegDate = await GetSysParameterAsync("IsUseRegDateInTarif");
            if (parUseRegDate != null)
            {
                if (Convert.ToBoolean(parUseRegDate.ParameterValue))
                    req.TransactionDate = regEntity.RegistrationDateTime;
            }

            req.TransactionDate = req.TransactionDate.Date;

            var personalBP = await GetSysParameterAsync("PersonalBusinessPartnerID");

            if (req.BusinessPartnerId == Convert.ToInt32(personalBP.ParameterValue))
            {
                return await GetStandardTariffAsync(regEntity.SiteCode, req.ItemId, req.TransactionDate, classEntity.ClassCategoryCode);
            }

            var contractEntity = await _context.CustomerContracts
                .FirstOrDefaultAsync(x => x.DocumentNo == req.DocumentNo);

            if (contractEntity == null)
            {
                return await GetStandardTariffAsync(regEntity.SiteCode, req.ItemId, req.TransactionDate, classEntity.ClassCategoryCode);
            }

            if (contractEntity.StartingDate <= DateOnly.FromDateTime(req.TransactionDate) &&
                contractEntity.EndingDate >= DateOnly.FromDateTime(req.TransactionDate))
            {
                if (contractEntity.GccoverageType == "X0104^03")
                {
                    return await HandlePlafonAsync(req, regEntity, classEntity, contractEntity);
                }
                else
                {
                    return await HandleNonPlafonAsync(req, regEntity, classEntity, contractEntity);
                }
            }

            return await GetStandardTariffAsync(
                regEntity.SiteCode,
                req.ItemId,
                req.TransactionDate,
                classEntity.ClassCategoryCode);
        }

        public async Task<TariffDto> GetTariffHomeCareAsync(TariffRequest req)
        {
            ValidateGetTariff("GetTariffHomeCare", req);

            var tariff = new TariffDto
            {
                IsDifferentClass = false,
                CostPrice = 0,
                StandardPrice = 0,
                CustomerPrice = 0,
                PersonalPrice = 0,
                DiscountPrice = 0,
                LaborCost = 0,
                MinVariablePrice = 0,
                MaxVariablePrice = 0,
            };

            var classEntity = await _context.Classes
                .FirstOrDefaultAsync(x => x.ClassCategoryCode == req.ChargeClassCode);

            var costEntity = await _context.ItemCosts
                .FirstOrDefaultAsync(x => x.SiteCode == req.SiteCode && x.ItemId == req.ItemId);

            if (costEntity != null)
            {
                tariff.CostPrice = (costEntity.Material ?? 0)
                    + (costEntity.Labor ?? 0)
                    + (costEntity.Overhead ?? 0)
                    + (costEntity.SubContract ?? 0)
                    + (costEntity.Burden ?? 0);

                tariff.LaborCost = (costEntity.Labor ?? 0);
            }

            var standardTariff = await GetStandardTariffAsync(req.SiteCode, req.ItemId, req.TransactionDate, classEntity.ClassCategoryCode);

            return new TariffDto
            {
                CostPrice = tariff.CostPrice,
                StandardPrice = standardTariff.StandardPrice,
                CustomerPrice = standardTariff.CustomerPrice,
                PersonalPrice = standardTariff.PersonalPrice,
                DiscountPrice = standardTariff.DiscountPrice,
                LaborCost = tariff.LaborCost,
                MinVariablePrice = standardTariff.MinVariablePrice,
                MaxVariablePrice = standardTariff.MaxVariablePrice,
                IsDifferentClass = standardTariff.IsDifferentClass,
            };
        }

        public async Task<TariffDto> GetTariffWalkInAsync(TariffRequest req)
        {
            ValidateGetTariff("GetTariffWalkIn", req);

            var tariff = new TariffDto();

            var classEntity = await _context.Classes
                .FirstOrDefaultAsync(x => x.ClassCode == req.ChargeClassCode);

            var costEntity = await _context.ItemCosts
                .FirstOrDefaultAsync(x => x.SiteCode == req.SiteCode && x.ItemId == req.ItemId);

            if (costEntity != null)
            {
                tariff.CostPrice = (costEntity.Material ?? 0)
                    + (costEntity.Labor ?? 0)
                    + (costEntity.Overhead ?? 0)
                    + (costEntity.SubContract ?? 0)
                    + (costEntity.Burden ?? 0);

                tariff.LaborCost = (costEntity.Labor ?? 0);
            }

            var standardTariff = await GetStandardTariffAsync(req.SiteCode, req.ItemId, req.TransactionDate, classEntity.ClassCategoryCode);

            return new TariffDto
            {
                CostPrice = tariff.CostPrice,
                StandardPrice = standardTariff.StandardPrice,
                CustomerPrice = standardTariff.CustomerPrice,
                PersonalPrice = standardTariff.PersonalPrice,
                DiscountPrice = standardTariff.DiscountPrice,
                LaborCost = tariff.LaborCost,
                MinVariablePrice = standardTariff.MinVariablePrice,
                MaxVariablePrice = standardTariff.MaxVariablePrice,
                IsDifferentClass = standardTariff.IsDifferentClass,
            };
        }

        public async Task<TariffDto> GetTariffWalkInCorporateAsync(TariffRequest req)
        {
            ValidateGetTariff("GetTariffWalkInCorporate", req);

            var tariff = new TariffDto();

            int businessPartnerId = 0;
            string documentNo = string.Empty;

            var regisEntity = await _context.Registrations
                .FirstOrDefaultAsync(x => x.RegistrationNo == req.RegistrationNo);

            var costEntity = await _context.ItemCosts
                .FirstOrDefaultAsync(x => x.SiteCode == req.SiteCode && x.ItemId == req.ItemId);

            if (costEntity != null)
            {
                tariff.CostPrice = (costEntity.Material ?? 0) 
                    + (costEntity.Labor ?? 0)
                    + (costEntity.Overhead ?? 0)
                    + (costEntity.SubContract ?? 0)
                    + (costEntity.Burden ?? 0);

                tariff.LaborCost = (costEntity.Labor ?? 0);
            }

            var classEntity = await _context.Classes
                .FirstOrDefaultAsync(x => x.ClassCode == req.ChargeClassCode);

            if (!string.IsNullOrEmpty(req.DocumentNo))
            {
                var documentNoSplit = req.DocumentNo.Split('-')[0]; 

                var contractEntity = await _context.CustomerContracts
                    .FirstOrDefaultAsync(x => x.DocumentNo == documentNoSplit);

                if (contractEntity != null)
                {
                    businessPartnerId = Convert.ToInt32(contractEntity.BusinessPartnerId);
                    documentNo = contractEntity.DocumentNo;
                }
            }

            var tariffCorporate = await GetCorporateTariffByBusinessPartnerAsync(
                req.SiteCode,
                req.ItemId,
                req.TransactionDate,
                req.ChargeClassCode,
                req.IsRecalculation,
                documentNo,
                businessPartnerId,
                regisEntity);

            if (tariffCorporate.StandardPrice == null)
            {
                var tariffStdWalkin = await GetTariffStandartWalkInAsync(req.SiteCode, req.ItemId, req.TransactionDate, classEntity);

                return new TariffDto
                {
                    StandardPrice = tariffStdWalkin.StandardPrice,
                    PersonalPrice = tariffStdWalkin.PersonalPrice,
                    CustomerPrice = tariffStdWalkin.CustomerPrice,
                    DiscountPrice = tariffStdWalkin.DiscountPrice,
                    MinVariablePrice = tariffStdWalkin.MinVariablePrice,
                    MaxVariablePrice = tariffStdWalkin.MaxVariablePrice,
                    CostPrice = tariff.CostPrice,
                    LaborCost = tariff.LaborCost,
                };
            }
            
            return new TariffDto
            {
                StandardPrice = tariffCorporate.StandardPrice,
                PersonalPrice = tariffCorporate.PersonalPrice,
                CustomerPrice = tariffCorporate.CustomerPrice,
                DiscountPrice = tariffCorporate.DiscountPrice,
                MinVariablePrice = tariffCorporate.MinVariablePrice,
                MaxVariablePrice = tariffCorporate.MaxVariablePrice,
                CostPrice = tariff.CostPrice,
                LaborCost = tariff.LaborCost,
            };
        }

        public async Task<TariffDto> GetTariffMCUAsync(TariffRequest req)
        {
            ValidateGetTariff("GetTariffMCU", req);

            var tariff = new TariffDto();

            var classEntity = await _context.Classes
                .FirstOrDefaultAsync(x => x.ClassCode == req.ChargeClassCode);

            var costEntity = await _context.ItemCosts
                .FirstOrDefaultAsync(x => x.SiteCode == req.SiteCode && x.ItemId == req.ItemId);

            if (costEntity != null)
            {
                tariff.CostPrice = (costEntity.Material ?? 0)
                    + (costEntity.Labor ?? 0)
                    + (costEntity.Overhead ?? 0)
                    + (costEntity.SubContract ?? 0)
                    + (costEntity.Burden ?? 0);

                tariff.LaborCost = (costEntity.Labor ?? 0);
            }

            var spUseRegDateInTrf = await GetSysParameterAsync("IsUseRegDateInTarif");
            var spPersonalBpId = await GetSysParameterAsync("PersonalBusinessPartnerID");

            if (Convert.ToBoolean(spUseRegDateInTrf.ParameterValue))
                req.TransactionDate = Convert.ToDateTime(DateTime.Now);

            req.TransactionDate = Convert.ToDateTime(req.TransactionDate.Date);

            if (req.BusinessPartnerId == Convert.ToInt32(spPersonalBpId.ParameterValue))
            {
                return await GetTariffStandartMCUAsync(req.SiteCode, req.ItemId, req.TransactionDate, classEntity);
            }
            else 
            {
                var contractEntity = await _context.CustomerContracts
                    .FirstOrDefaultAsync(x => x.DocumentNo == req.DocumentNo);

                if (contractEntity == null || contractEntity.DocumentNo == null)
                {
                    return await GetTariffStandartMCUAsync(req.SiteCode, req.ItemId, req.TransactionDate, classEntity);
                }

                if (contractEntity.StartingDate <= DateOnly.FromDateTime(req.TransactionDate) &&
                    contractEntity.EndingDate >= DateOnly.FromDateTime(req.TransactionDate))
                {
                    if (contractEntity.GccoverageType == "X0104^03")
                    {
                        return await GetTariffStandartMCUAsync(req.SiteCode, req.ItemId, req.TransactionDate, classEntity);
                    }
                    else
                    {
                        var coverClassEntity = await _context.Classes
                            .FirstOrDefaultAsync(x => x.ClassCode == req.CoveredClassCode);

                        var tariffCorporateEntity = await _context.ItemTariffCorporates
                            .FirstOrDefaultAsync(x => 
                                x.SiteCode == req.SiteCode &&
                                x.BusinessPartnerId == contractEntity.BusinessPartnerId &&
                                x.DocumentNo == contractEntity.DocumentNo &&
                                x.ItemId == req.ItemId &&
                                x.ClassCategoryCode == coverClassEntity.ClassCategoryCode &&
                                !x.IsDeleted);

                        var tariffPersonal = await GetTariffStandartMCUAsync(req.SiteCode, req.ItemId, req.TransactionDate, classEntity);

                        if (tariffCorporateEntity == null || tariffCorporateEntity.StandardPrice == null)
                        {
                            return await GetTariffStandartMCUAsync(req.SiteCode, req.ItemId, req.TransactionDate, classEntity);
                        }

                        if (classEntity.ClassCategoryCode == coverClassEntity.ClassCategoryCode)
                        {
                            return new TariffDto
                            {
                                StandardPrice = tariffCorporateEntity.StandardPrice,
                                CustomerPrice = tariffCorporateEntity.CustomerPrice,
                                DiscountPrice = tariffCorporateEntity.DiscountPrice,
                                PersonalPrice = tariffCorporateEntity.PersonalPrice,
                                MinVariablePrice = (tariff.CustomerPrice) + (tariff.PersonalPrice),
                                MaxVariablePrice = tariffPersonal.MaxVariablePrice,
                                CostPrice = tariff.CostPrice,
                                LaborCost = tariff.LaborCost
                            };
                        }

                        if (tariffPersonal.PersonalPrice >= (tariffCorporateEntity.CustomerPrice + tariffCorporateEntity.PersonalPrice))
                        {
                            return new TariffDto
                            {
                                StandardPrice = tariffPersonal.StandardPrice,
                                CustomerPrice = tariffCorporateEntity.CustomerPrice,
                                DiscountPrice = tariffCorporateEntity.DiscountPrice,
                                PersonalPrice = tariffCorporateEntity.PersonalPrice + (tariffPersonal.StandardPrice - tariffCorporateEntity.StandardPrice),
                                MinVariablePrice = tariffPersonal.MinVariablePrice,
                                MaxVariablePrice = tariffPersonal.MaxVariablePrice,
                                CostPrice = tariff.CostPrice,
                                LaborCost = tariff.LaborCost
                            };
                        }
                        else
                        {
                            return new TariffDto
                            {
                                StandardPrice = tariffCorporateEntity.StandardPrice,
                                CustomerPrice = tariffCorporateEntity.CustomerPrice,
                                DiscountPrice = tariffCorporateEntity.DiscountPrice,
                                PersonalPrice = tariffCorporateEntity.PersonalPrice,
                                MinVariablePrice = tariff.CustomerPrice + tariff.PersonalPrice,
                                MaxVariablePrice = tariffPersonal.MaxVariablePrice,
                                CostPrice = tariff.CostPrice,
                                LaborCost = tariff.LaborCost
                            };
                        }
                    }
                }
                else
                {
                    return await GetTariffStandartMCUAsync(req.SiteCode, req.ItemId, req.TransactionDate, classEntity);
                }
            }
        }

        private async Task<TariffDto> GetStandardTariffAsync(
            string siteCode, 
            int itemId, 
            DateTime transactionDate, 
            string classCategoryCode)
        {
            var tariffStandard = await _context.ItemTariffStandards
                .Where(x =>
                    x.SiteCode == siteCode &&
                    x.ItemId == itemId &&
                    x.ClassCategoryCode == classCategoryCode &&
                    x.StartingDate <= DateOnly.FromDateTime(transactionDate) &&
                    x.EndingDate >= DateOnly.FromDateTime(transactionDate) &&
                    !x.IsDeleted)
                .OrderByDescending(x => x.StartingDate)
                .ThenByDescending(x => x.LastUpdatedDateTime)
                .FirstOrDefaultAsync();

            if (tariffStandard == null)
            {
                tariffStandard = await _context.ItemTariffStandards
                    .Where(x =>
                        x.SiteCode == siteCode &&
                        x.ItemId == itemId &&
                        x.ClassCategoryCode == classCategoryCode &&
                        x.StartingDate <= DateOnly.FromDateTime(DateTime.Now) &&
                        x.EndingDate >= DateOnly.FromDateTime(transactionDate) &&
                        !x.IsDeleted)
                    .OrderByDescending(x => x.StartingDate)
                    .ThenByDescending(x => x.LastUpdatedDateTime)
                    .FirstOrDefaultAsync();
            }

            if (tariffStandard == null)
                return new TariffDto();

            return new TariffDto
            {
                StandardPrice = tariffStandard.StandardPrice,
                PersonalPrice = tariffStandard.PersonalPrice,
                CustomerPrice = tariffStandard.CustomerPrice,
                DiscountPrice = tariffStandard.DiscountPrice,
                MinVariablePrice = tariffStandard.MinVariablePrice,
                MaxVariablePrice = tariffStandard.MaxVariablePrice
            };
        }

        private async Task<TariffDto> GetStandardTariffPlafonAsync(
            string siteCode,
            int itemId,
            DateTime transactionDate,
            string classCategoryCode)
        {
            var docNo = await GetSysParameterAsync("DocumentPlafonOldTariff");

            var tariffStandard = await _context.ItemTariffStandards
                .Where(x =>
                    x.SiteCode == siteCode &&
                    x.ItemId == itemId &&
                    x.ClassCategoryCode == classCategoryCode &&
                    x.DocumentNo == (docNo.ParameterValue ?? "") &&
                    x.StartingDate <= DateOnly.FromDateTime(transactionDate) &&
                    x.EndingDate >= DateOnly.FromDateTime(transactionDate) &&
                    !x.IsDeleted)
                .OrderByDescending(x => x.StartingDate)
                .ThenByDescending(x => x.LastUpdatedDateTime)
                .FirstOrDefaultAsync();

            if (tariffStandard == null)
                return new TariffDto();

            return new TariffDto
            {
                StandardPrice = tariffStandard.StandardPrice,
                PersonalPrice = tariffStandard.PersonalPrice,
                CustomerPrice = tariffStandard.CustomerPrice,
                DiscountPrice = tariffStandard.DiscountPrice,
                MinVariablePrice = tariffStandard.MinVariablePrice,
                MaxVariablePrice = tariffStandard.MaxVariablePrice
            };
        }

        private async Task<TariffDto> GetCorporateTariffAsync(
            string siteCode,
            int itemId,
            DateTime transactionDate,
            string classCategoryCode,
            bool isRecalculation,
            string documentNo,
            Registration regEntity)
        {
            var document = isRecalculation ? documentNo : regEntity.CustomerDocumentNo;

            var tarifCorporate = await _context.ItemTariffCorporates
                .AsNoTracking()
                .Where(x =>
                    x.SiteCode == siteCode &&
                    x.ItemId == itemId &&
                    x.ClassCategoryCode == classCategoryCode &&
                    !x.IsDeleted &&
                    x.PersonalPrice > 0 &&
                    x.DocumentNo == document
                    )
                .OrderByDescending(x => x.StartingDate)
                .ThenByDescending(x => x.LastUpdatedDateTime)
                .FirstOrDefaultAsync();

            if (tarifCorporate == null)
                return new TariffDto();

            return new TariffDto 
            {
                StandardPrice = tarifCorporate.StandardPrice,
                CustomerPrice = tarifCorporate.CustomerPrice,
                DiscountPrice = tarifCorporate.DiscountPrice,
                PersonalPrice = tarifCorporate.PersonalPrice,
                MinVariablePrice = tarifCorporate.MinVariablePrice,
                MaxVariablePrice = tarifCorporate.MaxVariablePrice
            };
        }

        private async Task<TariffDto> GetCorporateTariffByBusinessPartnerAsync(
            string siteCode,
            int itemId,
            DateTime transactionDate,
            string classCategoryCode,
            bool isRecalculation,
            string documentNo,
            int businessPartnerId,
            Registration regEntity)
        {
            var tarifCorporate = await _context.ItemTariffCorporates
                .FirstOrDefaultAsync(x =>
                    x.SiteCode == siteCode &&
                    x.ItemId == itemId &&
                    x.ClassCategoryCode == classCategoryCode &&
                    x.BusinessPartnerId == businessPartnerId &&
                    x.DocumentNo == documentNo &&
                    !x.IsDeleted &&
                    x.PersonalPrice > 0);

            if (tarifCorporate == null)
                return new TariffDto();

            return new TariffDto 
            {
                StandardPrice = tarifCorporate.StandardPrice,
                CustomerPrice = tarifCorporate.CustomerPrice,
                DiscountPrice = tarifCorporate.DiscountPrice,
                PersonalPrice = tarifCorporate.PersonalPrice,
                MinVariablePrice = tarifCorporate.CustomerPrice + tarifCorporate.PersonalPrice,
                MaxVariablePrice = tarifCorporate.MaxVariablePrice
            };
        }

        private async Task<TariffDto> GetTariffStandartWalkInAsync(
            string siteCode, 
            int itemId, 
            DateTime transactionDate, 
            Class classEntity)
        {
            var tariffStandard = await _context.ItemTariffStandards
                .Where(x =>
                    x.SiteCode == siteCode &&
                    x.ItemId == itemId &&
                    x.ClassCategoryCode == classEntity.ClassCategoryCode &&
                    x.StartingDate <= DateOnly.FromDateTime(transactionDate) &&
                    x.EndingDate >= DateOnly.FromDateTime(transactionDate) &&
                    !x.IsDeleted)
                .OrderByDescending(x => x.StartingDate)
                .ThenByDescending(x => x.LastUpdatedDateTime)
                .FirstOrDefaultAsync();

            if (tariffStandard == null)
            {
                tariffStandard = await _context.ItemTariffStandards
                .Where(x =>
                    x.SiteCode == siteCode &&
                    x.ItemId == itemId &&
                    x.ClassCategoryCode == classEntity.ClassCategoryCode &&
                    x.StartingDate <= DateOnly.FromDateTime(DateTime.Now) &&
                    x.EndingDate >= DateOnly.FromDateTime(transactionDate) &&
                    !x.IsDeleted)
                .OrderByDescending(x => x.StartingDate)
                .ThenByDescending(x => x.LastUpdatedDateTime)
                .FirstOrDefaultAsync();
            }

            if (tariffStandard == null)
                return new TariffDto();

            return new TariffDto
            {
                StandardPrice = tariffStandard.StandardPrice,
                PersonalPrice = tariffStandard.PersonalPrice,
                CustomerPrice = tariffStandard.CustomerPrice,
                DiscountPrice = tariffStandard.DiscountPrice,
                MinVariablePrice = tariffStandard.MinVariablePrice,
                MaxVariablePrice = tariffStandard.MaxVariablePrice
            };
        }

        private async Task<TariffDto> GetTariffStandartMCUAsync(
            string siteCode, 
            int itemId,
            DateTime transactionDate,
            Class classEntity)
        {
            var tariffStandard = await _context.ItemTariffStandards
                .Where(x =>
                    x.SiteCode == siteCode &&
                    x.ItemId == itemId &&
                    x.ClassCategoryCode == classEntity.ClassCategoryCode &&
                    x.StartingDate <= DateOnly.FromDateTime(transactionDate) &&
                    x.EndingDate >= DateOnly.FromDateTime(transactionDate) &&
                    !x.IsDeleted)
                .OrderByDescending(x => x.StartingDate)
                .ThenByDescending(x => x.LastUpdatedDateTime)
                .FirstOrDefaultAsync();

            if (tariffStandard == null)
                return new TariffDto();

            return new TariffDto
            {
                StandardPrice = tariffStandard.StandardPrice,
                PersonalPrice = tariffStandard.PersonalPrice,
                CustomerPrice = tariffStandard.CustomerPrice,
                DiscountPrice = tariffStandard.DiscountPrice,
                MinVariablePrice = tariffStandard.MinVariablePrice,
                MaxVariablePrice = tariffStandard.MaxVariablePrice
            };
        }

        private async Task<TariffDto> HandlePlafonAsync(
            TariffRequest req,
            Registration regEntity,
            Class classEntity,
            CustomerContract contractEntity)
        {
            var isSpecialPlafon = false;
            var isSpecialPlafonMandaya = false;
            var isPlafonCoverage = false;

            var trfPlafon = await GetSysParameterAsync("IsUsingOldPlafonTariff");
            if (trfPlafon != null)
            {
                if (trfPlafon.ParameterValue == "1") isSpecialPlafon = true;
                if (trfPlafon.ParameterValue == "2") isSpecialPlafonMandaya = true;
            }

            var trfPlafonCoverage = await GetSysParameterAsync("IsUseTariffInhealth");
            if (trfPlafonCoverage != null)
                if (trfPlafonCoverage.ParameterValue == "1") isPlafonCoverage = true;

            if (isSpecialPlafon)
            {
                return await HandlePlafonSantaMariaAsync(
                    req, 
                    regEntity, 
                    classEntity, 
                    contractEntity);
            }

            if (isSpecialPlafonMandaya)
            {
                return await HandlePlafonMandayaAsync(
                    req,
                    regEntity,
                    classEntity,
                    contractEntity);
            }

            var sysParBpMandiriInhealth = await GetSysParameterAsync("InhealthMandiriBusinessPartnerID");
            var bpMandiriInhealth = sysParBpMandiriInhealth != null ? Convert.ToInt32(sysParBpMandiriInhealth) : 0;

            if (isPlafonCoverage && req.BusinessPartnerId == bpMandiriInhealth)
            {
                return await GetCorporateTariffByBusinessPartnerAsync(
                    regEntity.SiteCode,
                    req.ItemId,
                    req.TransactionDate,
                    req.ChargeClassCode,
                    req.IsRecalculation,
                    contractEntity.DocumentNo,
                    contractEntity.BusinessPartnerId,
                    regEntity);
            }

            return new TariffDto();
        }

        private async Task<TariffDto> HandleNonPlafonAsync(
            TariffRequest req,
            Registration regEntity,
            Class classEntity,
            CustomerContract contractEntity)
        {
            var coverClassEntity = await _context.Classes
                .FirstOrDefaultAsync(x => x.ClassCode == req.CoveredClassCode);

            var tarifCorporateEntity = await GetCorporateTariffByBusinessPartnerAsync(
                    regEntity.SiteCode,
                    req.ItemId,
                    req.TransactionDate,
                    coverClassEntity.ClassCategoryCode,
                    req.IsRecalculation,
                    contractEntity.DocumentNo,
                    contractEntity.BusinessPartnerId,
                    regEntity);

            var tarifPersonal = await GetStandardTariffAsync(
                regEntity.SiteCode,
                req.ItemId,
                req.TransactionDate,
                classEntity.ClassCategoryCode);

            if (tarifCorporateEntity == null || tarifCorporateEntity.StandardPrice == null)
            {
                return tarifPersonal;
            }

            if (classEntity.ClassCategoryCode == coverClassEntity.ClassCategoryCode)
            {
                return new TariffDto
                {
                    StandardPrice = tarifCorporateEntity.StandardPrice,
                    CustomerPrice = tarifCorporateEntity.CustomerPrice,
                    DiscountPrice = tarifCorporateEntity.DiscountPrice,
                    PersonalPrice = tarifCorporateEntity.PersonalPrice,
                    MinVariablePrice = tarifCorporateEntity.CustomerPrice + tarifCorporateEntity.PersonalPrice,
                    MaxVariablePrice = tarifPersonal.MaxVariablePrice
                };
            }
            else
            {
                var corporateTotal = (tarifCorporateEntity.CustomerPrice ?? 0) + (tarifCorporateEntity.PersonalPrice ?? 0);
                if ((tarifPersonal.PersonalPrice ?? 0) >= corporateTotal)
                {
                    return new TariffDto
                    {
                        StandardPrice = tarifPersonal.StandardPrice,
                        CustomerPrice = tarifCorporateEntity.CustomerPrice,
                        DiscountPrice = tarifCorporateEntity.DiscountPrice,
                        PersonalPrice = (tarifCorporateEntity.PersonalPrice ?? 0) + ((tarifPersonal.StandardPrice ?? 0) - (tarifCorporateEntity.StandardPrice ?? 0)),
                        MinVariablePrice = tarifPersonal.MinVariablePrice,
                        MaxVariablePrice = tarifPersonal.MaxVariablePrice,
                        IsDifferentClass = true
                    };
                }
                else
                {
                    return new TariffDto
                    {
                        StandardPrice = tarifCorporateEntity.StandardPrice,
                        CustomerPrice = tarifCorporateEntity.CustomerPrice,
                        DiscountPrice = tarifCorporateEntity.DiscountPrice,
                        PersonalPrice = tarifCorporateEntity.PersonalPrice,
                        MinVariablePrice = tarifCorporateEntity.CustomerPrice + tarifCorporateEntity.PersonalPrice,
                        MaxVariablePrice = tarifPersonal.MaxVariablePrice,
                    };
                }
            }

            return await GetStandardTariffAsync(
                regEntity.SiteCode,
                req.ItemId,
                req.TransactionDate,
                classEntity.ClassCategoryCode);
        }

        private async Task<TariffDto> HandlePlafonSantaMariaAsync(
            TariffRequest req,
            Registration regEntity,
            Class classEntity,
            CustomerContract contractEntity)
        {
            var sysBpNotUseOldTrf = await GetSysParameterAsync("BusinessPartnerNotUsePlafonOldTariff");
            var excludedBpList = sysBpNotUseOldTrf.ParameterValue + "|";
            string[] BusinessPartnerArr = excludedBpList.Split('|');
            BusinessPartnerArr = BusinessPartnerArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            int isInList = Array.IndexOf(BusinessPartnerArr, req.BusinessPartnerId.ToString());

            if (isInList > -1)
            {
                var getTariffCorporate = await GetCorporateTariffAsync(
                        regEntity.SiteCode,
                        req.ItemId,
                        req.TransactionDate,
                        classEntity.ClassCategoryCode,
                        req.IsRecalculation,
                        req.DocumentNo,
                        regEntity);

                if (getTariffCorporate != null)
                {
                    return new TariffDto
                    {
                        StandardPrice = getTariffCorporate.StandardPrice,
                        PersonalPrice = getTariffCorporate.PersonalPrice,
                        CustomerPrice = getTariffCorporate.CustomerPrice,
                        DiscountPrice = getTariffCorporate.DiscountPrice,
                        MinVariablePrice = getTariffCorporate.MinVariablePrice,
                        MaxVariablePrice = getTariffCorporate.MaxVariablePrice
                    };
                }
            }
            else
            {
                var getStdTrfPlafon = await GetStandardTariffPlafonAsync(
                        regEntity.SiteCode,
                        req.ItemId,
                        req.TransactionDate,
                        classEntity.ClassCategoryCode);

                if (getStdTrfPlafon != null && getStdTrfPlafon.PersonalPrice == 0)
                {
                    var getTrfCorporate = await GetCorporateTariffAsync(
                            regEntity.SiteCode,
                            req.ItemId,
                            req.TransactionDate,
                            classEntity.ClassCategoryCode,
                            req.IsRecalculation,
                            req.DocumentNo,
                            regEntity);

                    if (getTrfCorporate != null)
                    {
                        return new TariffDto
                        {
                            StandardPrice = getTrfCorporate.StandardPrice,
                            PersonalPrice = getTrfCorporate.PersonalPrice,
                            CustomerPrice = getTrfCorporate.CustomerPrice,
                            DiscountPrice = getTrfCorporate.DiscountPrice,
                            MinVariablePrice = getTrfCorporate.MinVariablePrice,
                            MaxVariablePrice = getTrfCorporate.MaxVariablePrice
                        };
                    }
                }
            }

            return await GetStandardTariffAsync(
                regEntity.SiteCode, 
                req.ItemId, 
                req.TransactionDate, 
                classEntity.ClassCategoryCode);
        }

        private async Task<TariffDto> HandlePlafonMandayaAsync(
            TariffRequest req,
            Registration regEntity,
            Class classEntity,
            CustomerContract contractEntity)
        {
            var getStdTrfPlafon = await GetStandardTariffPlafonAsync(
                        regEntity.SiteCode,
                        req.ItemId,
                        req.TransactionDate,
                        classEntity.ClassCategoryCode);

            if (getStdTrfPlafon != null && getStdTrfPlafon.PersonalPrice == 0)
            {
                var getTrfCorporate = await GetCorporateTariffAsync(
                        regEntity.SiteCode,
                        req.ItemId,
                        req.TransactionDate,
                        classEntity.ClassCategoryCode,
                        req.IsRecalculation,
                        req.DocumentNo,
                        regEntity);

                if (getTrfCorporate != null)
                {
                    return new TariffDto
                    {
                        StandardPrice = getTrfCorporate.StandardPrice,
                        PersonalPrice = getTrfCorporate.PersonalPrice,
                        CustomerPrice = getTrfCorporate.CustomerPrice,
                        DiscountPrice = getTrfCorporate.DiscountPrice,
                        MinVariablePrice = getTrfCorporate.MinVariablePrice,
                        MaxVariablePrice = getTrfCorporate.MaxVariablePrice
                    };
                }
            }

            return await GetStandardTariffAsync(
                regEntity.SiteCode,
                req.ItemId,
                req.TransactionDate,
                classEntity.ClassCategoryCode);
        }

        public async Task<SysParameter?> GetSysParameterAsync(string parameterCode)
        {
            var result = await _context.SysParameters
                .FirstOrDefaultAsync(x => x.ParameterCode == parameterCode);
            return result;
        }

        private void ValidateGetTariff(string methode, TariffRequest req)
        {
            var errors = new List<string>();

            if (methode == "GetTariff")
            {
                if (string.IsNullOrEmpty(req.SiteCode))
                {
                    errors.Add("SiteCode is required");
                }

                if (string.IsNullOrEmpty(req.RegistrationNo))
                {
                    errors.Add("RegistrationNo is required");
                }

                if (req.ItemId <= 0)
                {
                    errors.Add("ItemId is required");
                }

                if (req.TransactionDate == DateTime.MinValue)
                {
                    errors.Add("RegistrationNo is required");
                }

                if (req.IsRecalculation == null)
                {
                    errors.Add("IsRecalculation is required");
                }

                if (req.BusinessPartnerId <= 0)
                {
                    errors.Add("BusinessPartnerId is required");
                }
                else if (req.BusinessPartnerId != 1)
                {
                    if (string.IsNullOrEmpty(req.DocumentNo))
                    {
                        errors.Add("DocumentNo is required");
                    }

                    if (req.CoveredClassCode == null)
                    {
                        errors.Add("CoveredClassCode is required");
                    }
                }

                if (string.IsNullOrEmpty(req.ChargeClassCode))
                {
                    errors.Add("ChargeClassCode is required");
                }
            }

            if (methode == "GetTariffHomeCare")
            {
                if (string.IsNullOrEmpty(req.SiteCode))
                {
                    errors.Add("SiteCode is required");
                }

                if (req.ItemId <= 0)
                {
                    errors.Add("ItemId is required");
                }

                if (req.TransactionDate == DateTime.MinValue)
                {
                    errors.Add("RegistrationNo is required");
                }

                if (string.IsNullOrEmpty(req.ChargeClassCode))
                {
                    errors.Add("ChargeClassCode is required");
                }
            }

            if (methode == "GetTariffWalkIn")
            {
                if (string.IsNullOrEmpty(req.SiteCode))
                {
                    errors.Add("SiteCode is required");
                }

                if (req.ItemId <= 0)
                {
                    errors.Add("ItemId is required");
                }

                if (req.TransactionDate == DateTime.MinValue)
                {
                    errors.Add("RegistrationNo is required");
                }

                if (string.IsNullOrEmpty(req.ChargeClassCode))
                {
                    errors.Add("ChargeClassCode is required");
                }
            }

            if (methode == "GetTariffWalkInCorporate")
            {
                if (string.IsNullOrEmpty(req.SiteCode))
                {
                    errors.Add("SiteCode is required");
                }

                if (req.ItemId <= 0)
                {
                    errors.Add("ItemId is required");
                }

                if (req.TransactionDate == DateTime.MinValue)
                {
                    errors.Add("RegistrationNo is required");
                }

                if (req.IsRecalculation == null)
                {
                    errors.Add("IsRecalculation is required");
                }

                if (req.BusinessPartnerId <= 0)
                {
                    errors.Add("BusinessPartnerId is required");
                }

                if (string.IsNullOrEmpty(req.DocumentNo))
                {
                    errors.Add("DocumentNo is required");
                }

                if (string.IsNullOrEmpty(req.ChargeClassCode))
                {
                    errors.Add("ChargeClassCode is required");
                }

                if (req.CoveredClassCode == null)
                {
                    errors.Add("CoveredClassCode is required");
                }
            }

            if (methode == "GetTariffMCU")
            {
                if (string.IsNullOrEmpty(req.SiteCode))
                {
                    errors.Add("SiteCode is required");
                }

                if (req.ItemId <= 0)
                {
                    errors.Add("ItemId is required");
                }

                if (req.TransactionDate == DateTime.MinValue)
                {
                    errors.Add("RegistrationNo is required");
                }

                if (req.IsRecalculation == null)
                {
                    errors.Add("IsRecalculation is required");
                }

                if (req.BusinessPartnerId <= 0)
                {
                    errors.Add("BusinessPartnerId is required");
                }

                if (string.IsNullOrEmpty(req.DocumentNo))
                {
                    errors.Add("DocumentNo is required");
                }

                if (string.IsNullOrEmpty(req.ChargeClassCode))
                {
                    errors.Add("ChargeClassCode is required");
                }

                if (req.CoveredClassCode == null)
                {
                    errors.Add("CoveredClassCode is required");
                }
            }

            if (errors.Any())
            {
                throw new ArgumentException(string.Join(" | ", errors));
            }
        }
    }
}
