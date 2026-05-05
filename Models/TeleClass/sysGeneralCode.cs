using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TeleMedichineProject.Models.TeleClass;

[Index("ParentID", Name = "IX_sysGeneralCode_ParentID")]
public partial class sysGeneralCode
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string GeneralCodeID { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string GeneralCodeName1 { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string GeneralCodeName2 { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? ParentID { get; set; }

    public bool IsHeader { get; set; }

    public bool IsUsedBySystem { get; set; }

    public bool IsActive { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsDeleted { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastUpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdatedDateTime { get; set; }

    [InverseProperty("GCAGCGroupTypeNavigation")]
    public virtual ICollection<AGCGroup> AGCGroup { get; set; } = new List<AGCGroup>();

    [InverseProperty("GCIncomeTaxNameNavigation")]
    public virtual ICollection<AccountPayableHd> AccountPayableHd { get; set; } = new List<AccountPayableHd>();

    [InverseProperty("GCForceCloseReasonNavigation")]
    public virtual ICollection<AccountReceivableHd> AccountReceivableHd { get; set; } = new List<AccountReceivableHd>();

    [InverseProperty("GCCardProviderNavigation")]
    public virtual ICollection<AccountReceivablePaymentDt> AccountReceivablePaymentDtGCCardProviderNavigation { get; set; } = new List<AccountReceivablePaymentDt>();

    [InverseProperty("GCCardTypeNavigation")]
    public virtual ICollection<AccountReceivablePaymentDt> AccountReceivablePaymentDtGCCardTypeNavigation { get; set; } = new List<AccountReceivablePaymentDt>();

    [InverseProperty("GCPaymentMethodNavigation")]
    public virtual ICollection<AccountReceivablePaymentDt> AccountReceivablePaymentDtGCPaymentMethodNavigation { get; set; } = new List<AccountReceivablePaymentDt>();

    [InverseProperty("GCReferenceTransferBankNavigation")]
    public virtual ICollection<AccountReceivablePaymentDt> AccountReceivablePaymentDtGCReferenceTransferBankNavigation { get; set; } = new List<AccountReceivablePaymentDt>();

    [InverseProperty("GCAddressTypeNavigation")]
    public virtual ICollection<Address> AddressGCAddressTypeNavigation { get; set; } = new List<Address>();

    [InverseProperty("GCProvinceNavigation")]
    public virtual ICollection<Address> AddressGCProvinceNavigation { get; set; } = new List<Address>();

    [InverseProperty("GCAllergenTypeNavigation")]
    public virtual ICollection<Allergen> Allergen { get; set; } = new List<Allergen>();

    [InverseProperty("GCApprovalLevelNavigation")]
    public virtual ICollection<ApprovalLevel> ApprovalLevel { get; set; } = new List<ApprovalLevel>();

    [InverseProperty("GCConventionMethodNavigation")]
    public virtual ICollection<AssetDepreciationMethod> AssetDepreciationMethodGCConventionMethodNavigation { get; set; } = new List<AssetDepreciationMethod>();

    [InverseProperty("GCDepreciationMethodNavigation")]
    public virtual ICollection<AssetDepreciationMethod> AssetDepreciationMethodGCDepreciationMethodNavigation { get; set; } = new List<AssetDepreciationMethod>();

    [InverseProperty("GCCountryOfOriginNavigation")]
    public virtual ICollection<Assets> Assets { get; set; } = new List<Assets>();

    [InverseProperty("GCCardProviderNavigation")]
    public virtual ICollection<BankChargesDt> BankChargesDtGCCardProviderNavigation { get; set; } = new List<BankChargesDt>();

    [InverseProperty("GCCardTypeNavigation")]
    public virtual ICollection<BankChargesDt> BankChargesDtGCCardTypeNavigation { get; set; } = new List<BankChargesDt>();

    [InverseProperty("GCProviderNavigation")]
    public virtual BankChargesHd? BankChargesHd { get; set; }

    [InverseProperty("GCProviderNavigation")]
    public virtual ICollection<Bank> BankGCProviderNavigation { get; set; } = new List<Bank>();

    [InverseProperty("GCShortNameNavigation")]
    public virtual ICollection<Bank> BankGCShortNameNavigation { get; set; } = new List<Bank>();

    [InverseProperty("GCCleaningMethodNavigation")]
    public virtual ICollection<BedCleaning> BedCleaningGCCleaningMethodNavigation { get; set; } = new List<BedCleaning>();

    [InverseProperty("GCResultNavigation")]
    public virtual ICollection<BedCleaning> BedCleaningGCResultNavigation { get; set; } = new List<BedCleaning>();

    [InverseProperty("GCBedStatusNavigation")]
    public virtual ICollection<Bed> BedGCBedStatusNavigation { get; set; } = new List<Bed>();

    [InverseProperty("GCTypeOfBedNavigation")]
    public virtual ICollection<Bed> BedGCTypeOfBedNavigation { get; set; } = new List<Bed>();

    [InverseProperty("GCBedStatusNewNavigation")]
    public virtual ICollection<BedHistory> BedHistoryGCBedStatusNewNavigation { get; set; } = new List<BedHistory>();

    [InverseProperty("GCBedStatusOldNavigation")]
    public virtual ICollection<BedHistory> BedHistoryGCBedStatusOldNavigation { get; set; } = new List<BedHistory>();

    [InverseProperty("GCReservationStatusNavigation")]
    public virtual ICollection<BedReservation> BedReservationGCReservationStatusNavigation { get; set; } = new List<BedReservation>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<BedReservation> BedReservationGCSexNavigation { get; set; } = new List<BedReservation>();

    [InverseProperty("GCDiagramTypeNavigation")]
    public virtual ICollection<BodyPartDt> BodyPartDt { get; set; } = new List<BodyPartDt>();

    [InverseProperty("GCImageUrlNavigation")]
    public virtual ICollection<BodyPartSpecialty> BodyPartSpecialty { get; set; } = new List<BodyPartSpecialty>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<CHDAge> CHDAge { get; set; } = new List<CHDAge>();

    [InverseProperty("GCCHDBloodPressureValueNavigation")]
    public virtual ICollection<CHDBloodPressure> CHDBloodPressureGCCHDBloodPressureValueNavigation { get; set; } = new List<CHDBloodPressure>();

    [InverseProperty("GCDiastolicValueNavigation")]
    public virtual ICollection<CHDBloodPressure> CHDBloodPressureGCDiastolicValueNavigation { get; set; } = new List<CHDBloodPressure>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<CHDBloodPressure> CHDBloodPressureGCSexNavigation { get; set; } = new List<CHDBloodPressure>();

    [InverseProperty("GCSystolicValueNavigation")]
    public virtual ICollection<CHDBloodPressure> CHDBloodPressureGCSystolicValueNavigation { get; set; } = new List<CHDBloodPressure>();

    [InverseProperty("GCCHDPredictorTypeNavigation")]
    public virtual ICollection<CHDPredictor> CHDPredictorGCCHDPredictorTypeNavigation { get; set; } = new List<CHDPredictor>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<CHDPredictor> CHDPredictorGCSexNavigation { get; set; } = new List<CHDPredictor>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<CHDRisk> CHDRisk { get; set; } = new List<CHDRisk>();

    [InverseProperty("GCReasonNavigation")]
    public virtual ICollection<CancelPatientVisit> CancelPatientVisit { get; set; } = new List<CancelPatientVisit>();

    [InverseProperty("GCAccountRecordGroupNavigation")]
    public virtual ICollection<ChartOfAccount> ChartOfAccountGCAccountRecordGroupNavigation { get; set; } = new List<ChartOfAccount>();

    [InverseProperty("GCAccountTypeNavigation")]
    public virtual ICollection<ChartOfAccount> ChartOfAccountGCAccountTypeNavigation { get; set; } = new List<ChartOfAccount>();

    [InverseProperty("GCClassRLNavigation")]
    public virtual ICollection<Class> Class { get; set; } = new List<Class>();

    [InverseProperty("GCGuidelineTypeNavigation")]
    public virtual ICollection<ClinicalPathwayHd> ClinicalPathwayHd { get; set; } = new List<ClinicalPathwayHd>();

    [InverseProperty("GCDrugTypeNavigation")]
    public virtual ICollection<CompoundTemplateHd> CompoundTemplateHdGCDrugTypeNavigation { get; set; } = new List<CompoundTemplateHd>();

    [InverseProperty("GCFrequencyNavigation")]
    public virtual ICollection<CompoundTemplateHd> CompoundTemplateHdGCFrequencyNavigation { get; set; } = new List<CompoundTemplateHd>();

    [InverseProperty("GCRouteNavigation")]
    public virtual ICollection<CompoundTemplateHd> CompoundTemplateHdGCRouteNavigation { get; set; } = new List<CompoundTemplateHd>();

    [InverseProperty("GCCoverAdministrationTypeNavigation")]
    public virtual ICollection<CustomerContract> CustomerContractGCCoverAdministrationTypeNavigation { get; set; } = new List<CustomerContract>();

    [InverseProperty("GCCoverCitoComplicationTypeNavigation")]
    public virtual ICollection<CustomerContract> CustomerContractGCCoverCitoComplicationTypeNavigation { get; set; } = new List<CustomerContract>();

    [InverseProperty("GCCoverCitoTypeNavigation")]
    public virtual ICollection<CustomerContract> CustomerContractGCCoverCitoTypeNavigation { get; set; } = new List<CustomerContract>();

    [InverseProperty("GCCoverComplicationTypeNavigation")]
    public virtual ICollection<CustomerContract> CustomerContractGCCoverComplicationTypeNavigation { get; set; } = new List<CustomerContract>();

    [InverseProperty("GCCoverageTypeNavigation")]
    public virtual ICollection<CustomerContract> CustomerContractGCCoverageTypeNavigation { get; set; } = new List<CustomerContract>();

    [InverseProperty("GCCustomerTypeNavigation")]
    public virtual ICollection<Customer> CustomerGCCustomerTypeNavigation { get; set; } = new List<Customer>();

    [InverseProperty("GCInsuranceTypeNavigation")]
    public virtual ICollection<Customer> CustomerGCInsuranceTypeNavigation { get; set; } = new List<Customer>();

    [InverseProperty("GcDefaultOrderTypeNavigation")]
    public virtual ICollection<DepartmentServiceUnit> DepartmentServiceUnit { get; set; } = new List<DepartmentServiceUnit>();

    [InverseProperty("GCCardProviderNavigation")]
    public virtual ICollection<DepositPaymentDt> DepositPaymentDtGCCardProviderNavigation { get; set; } = new List<DepositPaymentDt>();

    [InverseProperty("GCCardTypeNavigation")]
    public virtual ICollection<DepositPaymentDt> DepositPaymentDtGCCardTypeNavigation { get; set; } = new List<DepositPaymentDt>();

    [InverseProperty("GCPaymentMethodNavigation")]
    public virtual ICollection<DepositPaymentDt> DepositPaymentDtGCPaymentMethodNavigation { get; set; } = new List<DepositPaymentDt>();

    [InverseProperty("GCCoffeeConsumptionNavigation")]
    public virtual ICollection<DietNutrient> DietNutrientGCCoffeeConsumptionNavigation { get; set; } = new List<DietNutrient>();

    [InverseProperty("GCDietTypeNavigation")]
    public virtual ICollection<DietNutrient> DietNutrientGCDietTypeNavigation { get; set; } = new List<DietNutrient>();

    [InverseProperty("GCFoodTextureNavigation")]
    public virtual ICollection<DietNutrient> DietNutrientGCFoodTextureNavigation { get; set; } = new List<DietNutrient>();

    [InverseProperty("GCMilkConsumptionNavigation")]
    public virtual ICollection<DietNutrient> DietNutrientGCMilkConsumptionNavigation { get; set; } = new List<DietNutrient>();

    [InverseProperty("GCTeaConsumptionNavigation")]
    public virtual ICollection<DietNutrient> DietNutrientGCTeaConsumptionNavigation { get; set; } = new List<DietNutrient>();

    [InverseProperty("GCVegetarianNavigation")]
    public virtual ICollection<DietNutrient> DietNutrientGCVegetarianNavigation { get; set; } = new List<DietNutrient>();

    [InverseProperty("GCDistributionOrderTypeNavigation")]
    public virtual ICollection<DistributionOrderHd> DistributionOrderHd { get; set; } = new List<DistributionOrderHd>();

    [InverseProperty("GCDrugStatusNavigation")]
    public virtual ICollection<DrugAdministration> DrugAdministration { get; set; } = new List<DrugAdministration>();

    [InverseProperty("GCDrugTypeNavigation")]
    public virtual ICollection<DrugDispensingDt> DrugDispensingDtGCDrugTypeNavigation { get; set; } = new List<DrugDispensingDt>();

    [InverseProperty("GCRouteNavigation")]
    public virtual ICollection<DrugDispensingDt> DrugDispensingDtGCRouteNavigation { get; set; } = new List<DrugDispensingDt>();

    [InverseProperty("GCOrderTypeNavigation")]
    public virtual ICollection<DrugDispensingHd> DrugDispensingHd { get; set; } = new List<DrugDispensingHd>();

    [InverseProperty("GCDrugInteractionDocumentationNavigation")]
    public virtual ICollection<DrugInteraction> DrugInteractionGCDrugInteractionDocumentationNavigation { get; set; } = new List<DrugInteraction>();

    [InverseProperty("GCDrugInteractionSeverityNavigation")]
    public virtual ICollection<DrugInteraction> DrugInteractionGCDrugInteractionSeverityNavigation { get; set; } = new List<DrugInteraction>();

    [InverseProperty("GCDrugReturnReasonNavigation")]
    public virtual ICollection<DrugReturnHd> DrugReturnHd { get; set; } = new List<DrugReturnHd>();

    [InverseProperty("GCEmbalaceLabelNavigation")]
    public virtual ICollection<EmbalaceHd> EmbalaceHd { get; set; } = new List<EmbalaceHd>();

    [InverseProperty("GCOccupationNavigation")]
    public virtual ICollection<EmergencyContact> EmergencyContactGCOccupationNavigation { get; set; } = new List<EmergencyContact>();

    [InverseProperty("GCRelationshipNavigation")]
    public virtual ICollection<EmergencyContact> EmergencyContactGCRelationshipNavigation { get; set; } = new List<EmergencyContact>();

    [InverseProperty("GCFamilyRelationNavigation")]
    public virtual ICollection<EmployeeFamily> EmployeeFamily { get; set; } = new List<EmployeeFamily>();

    [InverseProperty("GCBloodTypeNavigation")]
    public virtual ICollection<Employee> EmployeeGCBloodTypeNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCEmployeeStatusNavigation")]
    public virtual ICollection<Employee> EmployeeGCEmployeeStatusNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCGolonganNavigation")]
    public virtual ICollection<Employee> EmployeeGCGolonganNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCMaritalStatusNavigation")]
    public virtual ICollection<Employee> EmployeeGCMaritalStatusNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCNationalityNavigation")]
    public virtual ICollection<Employee> EmployeeGCNationalityNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCPayrollPeriodTypeNavigation")]
    public virtual ICollection<Employee> EmployeeGCPayrollPeriodTypeNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCPerfomanceNavigation")]
    public virtual ICollection<Employee> EmployeeGCPerfomanceNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCReligionNavigation")]
    public virtual ICollection<Employee> EmployeeGCReligionNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<Employee> EmployeeGCSexNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCTaxStatusNavigation")]
    public virtual ICollection<Employee> EmployeeGCTaxStatusNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GcAgcEmployeeNavigation")]
    public virtual ICollection<Employee> EmployeeGcAgcEmployeeNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GcRlKualifikasiPendidikanNavigation")]
    public virtual ICollection<Employee> EmployeeGcRlKualifikasiPendidikanNavigation { get; set; } = new List<Employee>();

    [InverseProperty("GCPerfomanceNavigation")]
    public virtual ICollection<EmployeeTerminate> EmployeeTerminateGCPerfomanceNavigation { get; set; } = new List<EmployeeTerminate>();

    [InverseProperty("GCTerminateTypeNavigation")]
    public virtual ICollection<EmployeeTerminate> EmployeeTerminateGCTerminateTypeNavigation { get; set; } = new List<EmployeeTerminate>();

    [InverseProperty("GcEmployeeStatusFromNavigation")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistoryGcEmployeeStatusFromNavigation { get; set; } = new List<EmployeeWorkingHistory>();

    [InverseProperty("GcEmployeeStatusToNavigation")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistoryGcEmployeeStatusToNavigation { get; set; } = new List<EmployeeWorkingHistory>();

    [InverseProperty("GcTypeNavigation")]
    public virtual ICollection<EmployeeWorkingHistory> EmployeeWorkingHistoryGcTypeNavigation { get; set; } = new List<EmployeeWorkingHistory>();

    [InverseProperty("GCIssueDescriptionNavigation")]
    public virtual ICollection<Engineering> EngineeringGCIssueDescriptionNavigation { get; set; } = new List<Engineering>();

    [InverseProperty("GCIssueTypeNavigation")]
    public virtual ICollection<Engineering> EngineeringGCIssueTypeNavigation { get; set; } = new List<Engineering>();

    [InverseProperty("GCStatusNavigation")]
    public virtual ICollection<Engineering> EngineeringGCStatusNavigation { get; set; } = new List<Engineering>();

    [InverseProperty("GCDiagnosisTypeNavigation")]
    public virtual ICollection<EpisodeDiagnosis> EpisodeDiagnosisGCDiagnosisTypeNavigation { get; set; } = new List<EpisodeDiagnosis>();

    [InverseProperty("GCDifferentialStatusNavigation")]
    public virtual ICollection<EpisodeDiagnosis> EpisodeDiagnosisGCDifferentialStatusNavigation { get; set; } = new List<EpisodeDiagnosis>();

    [InverseProperty("GCFinalStatusNavigation")]
    public virtual ICollection<EpisodeDiagnosis> EpisodeDiagnosisGCFinalStatusNavigation { get; set; } = new List<EpisodeDiagnosis>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<ExaminationReference> ExaminationReference { get; set; } = new List<ExaminationReference>();

    [InverseProperty("GcAfiStatusNavigation")]
    public virtual ICollection<FetalMeasurementHd> FetalMeasurementHd { get; set; } = new List<FetalMeasurementHd>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<GuidelineDt> GuidelineDt { get; set; } = new List<GuidelineDt>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<GuidelineDtItem> GuidelineDtItem { get; set; } = new List<GuidelineDtItem>();

    [InverseProperty("GCPathologyNavigation")]
    public virtual ICollection<GuidelineHd> GuidelineHd { get; set; } = new List<GuidelineHd>();

    [InverseProperty("GCGuidelineTypeNavigation")]
    public virtual ICollection<GuidelineInclusion> GuidelineInclusionGCGuidelineTypeNavigation { get; set; } = new List<GuidelineInclusion>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<GuidelineInclusion> GuidelineInclusionGCSexNavigation { get; set; } = new List<GuidelineInclusion>();

    [InverseProperty("GCGuidelineTypeNavigation")]
    public virtual ICollection<GuidelineInclusionHd> GuidelineInclusionHdGCGuidelineTypeNavigation { get; set; } = new List<GuidelineInclusionHd>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<GuidelineInclusionHd> GuidelineInclusionHdGCSexNavigation { get; set; } = new List<GuidelineInclusionHd>();

    [InverseProperty("GCReceivingApplicationNavigation")]
    public virtual ICollection<HL7Message> HL7MessageGCReceivingApplicationNavigation { get; set; } = new List<HL7Message>();

    [InverseProperty("GCSendingApplicationNavigation")]
    public virtual ICollection<HL7Message> HL7MessageGCSendingApplicationNavigation { get; set; } = new List<HL7Message>();

    [InverseProperty("GCThirdPartyNavigation")]
    public virtual ICollection<HL7ThirdParty> HL7ThirdParty { get; set; } = new List<HL7ThirdParty>();

    [InverseProperty("GCICDChapterNavigation")]
    public virtual ICollection<ICDBlock> ICDBlock { get; set; } = new List<ICDBlock>();

    [InverseProperty("GcIcuIndicatorNavigation")]
    public virtual ICollection<IcuIndicatorDt> IcuIndicatorDt { get; set; } = new List<IcuIndicatorDt>();

    [InverseProperty("GCStatusNavigation")]
    public virtual ICollection<IcuIndicatorHd> IcuIndicatorHdGCStatusNavigation { get; set; } = new List<IcuIndicatorHd>();

    [InverseProperty("GcIcuTemplateNavigation")]
    public virtual ICollection<IcuIndicatorHd> IcuIndicatorHdGcIcuTemplateNavigation { get; set; } = new List<IcuIndicatorHd>();

    [InverseProperty("GCTemplateTypeNavigation")]
    public virtual ICollection<IcuTemplate> IcuTemplate { get; set; } = new List<IcuTemplate>();

    [InverseProperty("GCNationalityNavigation")]
    public virtual ICollection<ImportMCUCorporate> ImportMCUCorporate { get; set; } = new List<ImportMCUCorporate>();

    [InverseProperty("GCStatusNavigation")]
    public virtual ICollection<InacbgClaim> InacbgClaim { get; set; } = new List<InacbgClaim>();

    [InverseProperty("GCGrouperTitleNavigation")]
    public virtual ICollection<InacbgGrouper> InacbgGrouper { get; set; } = new List<InacbgGrouper>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<IncomeTaxByDepartment> IncomeTaxByDepartment { get; set; } = new List<IncomeTaxByDepartment>();

    [InverseProperty("GCInfectiousDiseaseCategoryNavigation")]
    public virtual ICollection<InfectiousDisease> InfectiousDiseaseGCInfectiousDiseaseCategoryNavigation { get; set; } = new List<InfectiousDisease>();

    [InverseProperty("GCInfectiousDiseaseTypeNavigation")]
    public virtual ICollection<InfectiousDisease> InfectiousDiseaseGCInfectiousDiseaseTypeNavigation { get; set; } = new List<InfectiousDisease>();

    [InverseProperty("GCIntakeOutputTypeNavigation")]
    public virtual ICollection<IntakeOutputDt> IntakeOutputDt { get; set; } = new List<IntakeOutputDt>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<InventoryRevaluationHd> InventoryRevaluationHd { get; set; } = new List<InventoryRevaluationHd>();

    [InverseProperty("Parent")]
    public virtual ICollection<sysGeneralCode> InverseParent { get; set; } = new List<sysGeneralCode>();

    [InverseProperty("GCMonitoringTypeNavigation")]
    public virtual ICollection<IpAddressMonitoring> IpAddressMonitoring { get; set; } = new List<IpAddressMonitoring>();

    [InverseProperty("GCIssuedUnplannedTypeNavigation")]
    public virtual ICollection<IssuedUnplannedHd> IssuedUnplannedHd { get; set; } = new List<IssuedUnplannedHd>();

    [InverseProperty("GCDrugClassNavigation")]
    public virtual ICollection<ItemBrand> ItemBrandGCDrugClassNavigation { get; set; } = new List<ItemBrand>();

    [InverseProperty("GCPregnancyCategoryNavigation")]
    public virtual ICollection<ItemBrand> ItemBrandGCPregnancyCategoryNavigation { get; set; } = new List<ItemBrand>();

    [InverseProperty("GCCompileTypeNavigation")]
    public virtual ICollection<ItemCompileMCU> ItemCompileMCU { get; set; } = new List<ItemCompileMCU>();

    [InverseProperty("GCDrugTypeNavigation")]
    public virtual ICollection<ItemDrug> ItemDrugGCDrugTypeNavigation { get; set; } = new List<ItemDrug>();

    [InverseProperty("GCNarkotikaNavigation")]
    public virtual ICollection<ItemDrug> ItemDrugGCNarkotikaNavigation { get; set; } = new List<ItemDrug>();

    [InverseProperty("GCRouteNavigation")]
    public virtual ICollection<ItemDrug> ItemDrugGCRouteNavigation { get; set; } = new List<ItemDrug>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<Item> ItemGCItemTypeNavigation { get; set; } = new List<Item>();

    [InverseProperty("GCPhysicianFeeItemTypeNavigation")]
    public virtual ICollection<Item> ItemGCPhysicianFeeItemTypeNavigation { get; set; } = new List<Item>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<ItemGroup> ItemGroup { get; set; } = new List<ItemGroup>();

    [InverseProperty("GCProfileNavigation")]
    public virtual ICollection<ItemMasterIncentive> ItemMasterIncentive { get; set; } = new List<ItemMasterIncentive>();

    [InverseProperty("GCMostFrequentTypeNavigation")]
    public virtual ICollection<ItemMostFrequent> ItemMostFrequent { get; set; } = new List<ItemMostFrequent>();

    [InverseProperty("GCOrderPolicyNavigation")]
    public virtual ICollection<ItemPlanning> ItemPlanning { get; set; } = new List<ItemPlanning>();

    [InverseProperty("GCMemberNavigation")]
    public virtual ICollection<ItemTariffStandard> ItemTariffStandard { get; set; } = new List<ItemTariffStandard>();

    [InverseProperty("GCItemMasterNavigation")]
    public virtual ICollection<ItemTypeMaster> ItemTypeMasterGCItemMasterNavigation { get; set; } = new List<ItemTypeMaster>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<ItemTypeMaster> ItemTypeMasterGCItemTypeNavigation { get; set; } = new List<ItemTypeMaster>();

    [InverseProperty("GCJobOrderStatusNavigation")]
    public virtual ICollection<JobOrderDt> JobOrderDtGCJobOrderStatusNavigation { get; set; } = new List<JobOrderDt>();

    [InverseProperty("GCOrderTypeNavigation")]
    public virtual ICollection<JobOrderDt> JobOrderDtGCOrderTypeNavigation { get; set; } = new List<JobOrderDt>();

    [InverseProperty("GCJobOrderStatusNavigation")]
    public virtual ICollection<JobOrderDtMedicalSuppiles> JobOrderDtMedicalSuppilesGCJobOrderStatusNavigation { get; set; } = new List<JobOrderDtMedicalSuppiles>();

    [InverseProperty("GCOrderTypeNavigation")]
    public virtual ICollection<JobOrderDtMedicalSuppiles> JobOrderDtMedicalSuppilesGCOrderTypeNavigation { get; set; } = new List<JobOrderDtMedicalSuppiles>();

    [InverseProperty("GCDrugTypeNavigation")]
    public virtual ICollection<JobOrderDtMedication> JobOrderDtMedicationGCDrugTypeNavigation { get; set; } = new List<JobOrderDtMedication>();

    [InverseProperty("GCFrequencyNavigation")]
    public virtual ICollection<JobOrderDtMedication> JobOrderDtMedicationGCFrequencyNavigation { get; set; } = new List<JobOrderDtMedication>();

    [InverseProperty("GCMedicationTypeNavigation")]
    public virtual ICollection<JobOrderDtMedication> JobOrderDtMedicationGCMedicationTypeNavigation { get; set; } = new List<JobOrderDtMedication>();

    [InverseProperty("GCOrderTypeNavigation")]
    public virtual ICollection<JobOrderDtMedication> JobOrderDtMedicationGCOrderTypeNavigation { get; set; } = new List<JobOrderDtMedication>();

    [InverseProperty("GCRouteNavigation")]
    public virtual ICollection<JobOrderDtMedication> JobOrderDtMedicationGCRouteNavigation { get; set; } = new List<JobOrderDtMedication>();

    [InverseProperty("GCOrderTypeNavigation")]
    public virtual ICollection<JobOrderHd> JobOrderHd { get; set; } = new List<JobOrderHd>();

    [InverseProperty("GCCashBankTypeNavigation")]
    public virtual ICollection<JournalCashBankHd> JournalCashBankHdGCCashBankTypeNavigation { get; set; } = new List<JournalCashBankHd>();

    [InverseProperty("GCJournalTypeNavigation")]
    public virtual ICollection<JournalCashBankHd> JournalCashBankHdGCJournalTypeNavigation { get; set; } = new List<JournalCashBankHd>();

    [InverseProperty("GCJournalTypeNavigation")]
    public virtual ICollection<JournalHd> JournalHd { get; set; } = new List<JournalHd>();

    [InverseProperty("GCLeavePeriodNavigation")]
    public virtual ICollection<LeaveType> LeaveType { get; set; } = new List<LeaveType>();

    [InverseProperty("Parent")]
    public virtual ICollection<MCUHealthItemGroup> MCUHealthItemGroup { get; set; } = new List<MCUHealthItemGroup>();

    [InverseProperty("GCHealthStatusGeneratedNavigation")]
    public virtual ICollection<MCUHealthSummary> MCUHealthSummaryGCHealthStatusGeneratedNavigation { get; set; } = new List<MCUHealthSummary>();

    [InverseProperty("GCHealthStatusNavigation")]
    public virtual ICollection<MCUHealthSummary> MCUHealthSummaryGCHealthStatusNavigation { get; set; } = new List<MCUHealthSummary>();

    [InverseProperty("GCGroupIndicatorNavigation")]
    public virtual ICollection<METargetHd> METargetHd { get; set; } = new List<METargetHd>();

    [InverseProperty("GcItemTypeNavigation")]
    public virtual ICollection<MarkUpPrice> MarkUpPrice { get; set; } = new List<MarkUpPrice>();

    [InverseProperty("GCMRComplitionTypeNavigation")]
    public virtual ICollection<MaterialRequestCompletionHd> MaterialRequestCompletionHd { get; set; } = new List<MaterialRequestCompletionHd>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<MaterialRequestHd> MaterialRequestHd { get; set; } = new List<MaterialRequestHd>();

    [InverseProperty("GCMedicalRecordCategoryNavigation")]
    public virtual ICollection<MedicalRecordList> MedicalRecordList { get; set; } = new List<MedicalRecordList>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<MobileMembership> MobileMembership { get; set; } = new List<MobileMembership>();

    [InverseProperty("GCToothNavigation")]
    public virtual ICollection<OdontogramMCU> OdontogramMCUGCToothNavigation { get; set; } = new List<OdontogramMCU>();

    [InverseProperty("GCToothProblemNavigation")]
    public virtual ICollection<OdontogramMCU> OdontogramMCUGCToothProblemNavigation { get; set; } = new List<OdontogramMCU>();

    [InverseProperty("GCDistributionOrderTypeNavigation")]
    public virtual ICollection<OutstandingDOHd> OutstandingDOHd { get; set; } = new List<OutstandingDOHd>();

    [InverseProperty("GCEmploymentStatusNavigation")]
    public virtual ICollection<Paramedic> ParamedicGCEmploymentStatusNavigation { get; set; } = new List<Paramedic>();

    [InverseProperty("GCNationalityNavigation")]
    public virtual ICollection<Paramedic> ParamedicGCNationalityNavigation { get; set; } = new List<Paramedic>();

    [InverseProperty("GCParamedicTypeNavigation")]
    public virtual ICollection<Paramedic> ParamedicGCParamedicTypeNavigation { get; set; } = new List<Paramedic>();

    [InverseProperty("GCReligionNavigation")]
    public virtual ICollection<Paramedic> ParamedicGCReligionNavigation { get; set; } = new List<Paramedic>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<Paramedic> ParamedicGCSexNavigation { get; set; } = new List<Paramedic>();

    [ForeignKey("ParentID")]
    [InverseProperty("InverseParent")]
    public virtual sysGeneralCode? Parent { get; set; }

    [InverseProperty("GCAPGARTypeNavigation")]
    public virtual ICollection<PatientAPGAR> PatientAPGARGCAPGARTypeNavigation { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("GCActivityMuscleToneNavigation")]
    public virtual ICollection<PatientAPGAR> PatientAPGARGCActivityMuscleToneNavigation { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("GCAppearanceSkinColorNavigation")]
    public virtual ICollection<PatientAPGAR> PatientAPGARGCAppearanceSkinColorNavigation { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("GCGrimaceReflexIrritabilityNavigation")]
    public virtual ICollection<PatientAPGAR> PatientAPGARGCGrimaceReflexIrritabilityNavigation { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("GCPulseHeartRateNavigation")]
    public virtual ICollection<PatientAPGAR> PatientAPGARGCPulseHeartRateNavigation { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("GCRespirationBreathingNavigation")]
    public virtual ICollection<PatientAPGAR> PatientAPGARGCRespirationBreathingNavigation { get; set; } = new List<PatientAPGAR>();

    [InverseProperty("GCAllergenTypeNavigation")]
    public virtual ICollection<PatientAllergy> PatientAllergyGCAllergenTypeNavigation { get; set; } = new List<PatientAllergy>();

    [InverseProperty("GCAllergySeverityNavigation")]
    public virtual ICollection<PatientAllergy> PatientAllergyGCAllergySeverityNavigation { get; set; } = new List<PatientAllergy>();

    [InverseProperty("GCAllergySourceNavigation")]
    public virtual ICollection<PatientAllergy> PatientAllergyGCAllergySourceNavigation { get; set; } = new List<PatientAllergy>();

    [InverseProperty("GCAllergyStatusNavigation")]
    public virtual ICollection<PatientAllergy> PatientAllergyGCAllergyStatusNavigation { get; set; } = new List<PatientAllergy>();

    [InverseProperty("GCStatusNavigation")]
    public virtual ICollection<PatientAntibiotik> PatientAntibiotik { get; set; } = new List<PatientAntibiotik>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<PatientAttendance> PatientAttendance { get; set; } = new List<PatientAttendance>();

    [InverseProperty("GCActivityNavigation")]
    public virtual ICollection<PatientBPU> PatientBPUGCActivityNavigation { get; set; } = new List<PatientBPU>();

    [InverseProperty("GCFrictionAndShearNavigation")]
    public virtual ICollection<PatientBPU> PatientBPUGCFrictionAndShearNavigation { get; set; } = new List<PatientBPU>();

    [InverseProperty("GCMobilityNavigation")]
    public virtual ICollection<PatientBPU> PatientBPUGCMobilityNavigation { get; set; } = new List<PatientBPU>();

    [InverseProperty("GCMoistureNavigation")]
    public virtual ICollection<PatientBPU> PatientBPUGCMoistureNavigation { get; set; } = new List<PatientBPU>();

    [InverseProperty("GCNutritionNavigation")]
    public virtual ICollection<PatientBPU> PatientBPUGCNutritionNavigation { get; set; } = new List<PatientBPU>();

    [InverseProperty("GCSensoryPerceptionNavigation")]
    public virtual ICollection<PatientBPU> PatientBPUGCSensoryPerceptionNavigation { get; set; } = new List<PatientBPU>();

    [InverseProperty("GCBornConditionNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecordGCBornConditionNavigation { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("GCCaesarMethodNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecordGCCaesarMethodNavigation { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("GCDeliveryLocationNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecordGCDeliveryLocationNavigation { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("GCDeliveryMethodNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecordGCDeliveryMethodNavigation { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("GCParamedicTypeNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecordGCParamedicTypeNavigation { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("GCStatusRLPerinatologyNavigation")]
    public virtual ICollection<PatientBirthRecord> PatientBirthRecordGCStatusRLPerinatologyNavigation { get; set; } = new List<PatientBirthRecord>();

    [InverseProperty("GCDiastolicNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRiskGCDiastolicNavigation { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("GCSystolicNavigation")]
    public virtual ICollection<PatientCHDRisk> PatientCHDRiskGCSystolicNavigation { get; set; } = new List<PatientCHDRisk>();

    [InverseProperty("GCDocumentTypeNavigation")]
    public virtual ICollection<PatientDocument> PatientDocument { get; set; } = new List<PatientDocument>();

    [InverseProperty("GCBrainstemReflexesNavigation")]
    public virtual ICollection<PatientFCS> PatientFCSGCBrainstemReflexesNavigation { get; set; } = new List<PatientFCS>();

    [InverseProperty("GCEyeResponseNavigation")]
    public virtual ICollection<PatientFCS> PatientFCSGCEyeResponseNavigation { get; set; } = new List<PatientFCS>();

    [InverseProperty("GCMotorResponseFCSNavigation")]
    public virtual ICollection<PatientFCS> PatientFCSGCMotorResponseFCSNavigation { get; set; } = new List<PatientFCS>();

    [InverseProperty("GCRespirationFCSNavigation")]
    public virtual ICollection<PatientFCS> PatientFCSGCRespirationFCSNavigation { get; set; } = new List<PatientFCS>();

    [InverseProperty("GCRelationShipNavigation")]
    public virtual ICollection<PatientFamily> PatientFamily { get; set; } = new List<PatientFamily>();

    [InverseProperty("GCBloodTypeNavigation")]
    public virtual ICollection<Patient> PatientGCBloodTypeNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCDependentTypeNavigation")]
    public virtual ICollection<Patient> PatientGCDependentTypeNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCEducationNavigation")]
    public virtual ICollection<Patient> PatientGCEducationNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCMaritalStatusNavigation")]
    public virtual ICollection<Patient> PatientGCMaritalStatusNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCNationalityNavigation")]
    public virtual ICollection<Patient> PatientGCNationalityNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCOccupationNavigation")]
    public virtual ICollection<Patient> PatientGCOccupationNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCPatientCategoryNavigation")]
    public virtual ICollection<Patient> PatientGCPatientCategoryNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCRaceNavigation")]
    public virtual ICollection<Patient> PatientGCRaceNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCReligionNavigation")]
    public virtual ICollection<Patient> PatientGCReligionNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCEyeOpeningNavigation")]
    public virtual ICollection<PatientGCS> PatientGCSGCEyeOpeningNavigation { get; set; } = new List<PatientGCS>();

    [InverseProperty("GCMotorResponseNavigation")]
    public virtual ICollection<PatientGCS> PatientGCSGCMotorResponseNavigation { get; set; } = new List<PatientGCS>();

    [InverseProperty("GCVerbalResponseNavigation")]
    public virtual ICollection<PatientGCS> PatientGCSGCVerbalResponseNavigation { get; set; } = new List<PatientGCS>();

    [InverseProperty("GCEyeOpeningNavigation")]
    public virtual ICollection<PatientGCSPediatric> PatientGCSPediatricGCEyeOpeningNavigation { get; set; } = new List<PatientGCSPediatric>();

    [InverseProperty("GCMotorResponseNavigation")]
    public virtual ICollection<PatientGCSPediatric> PatientGCSPediatricGCMotorResponseNavigation { get; set; } = new List<PatientGCSPediatric>();

    [InverseProperty("GCVerbalResponseNavigation")]
    public virtual ICollection<PatientGCSPediatric> PatientGCSPediatricGCVerbalResponseNavigation { get; set; } = new List<PatientGCSPediatric>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<Patient> PatientGCSexNavigation { get; set; } = new List<Patient>();

    [InverseProperty("GCCompileTypeNavigation")]
    public virtual ICollection<PatientMCUCompileHd> PatientMCUCompileHd { get; set; } = new List<PatientMCUCompileHd>();

    [InverseProperty("GCInstructionByNavigation")]
    public virtual ICollection<PatientNotes> PatientNotesGCInstructionByNavigation { get; set; } = new List<PatientNotes>();

    [InverseProperty("GCPatientNotesTypeNavigation")]
    public virtual ICollection<PatientNotes> PatientNotesGCPatientNotesTypeNavigation { get; set; } = new List<PatientNotes>();

    [InverseProperty("GCRefferenceTypeNavigation")]
    public virtual ICollection<PatientNotes> PatientNotesGCRefferenceTypeNavigation { get; set; } = new List<PatientNotes>();

    [InverseProperty("GCToothNavigation")]
    public virtual ICollection<PatientOdontogram> PatientOdontogramGCToothNavigation { get; set; } = new List<PatientOdontogram>();

    [InverseProperty("GCToothProblemNavigation")]
    public virtual ICollection<PatientOdontogram> PatientOdontogramGCToothProblemNavigation { get; set; } = new List<PatientOdontogram>();

    [InverseProperty("GCToothNavigation")]
    public virtual ICollection<PatientOdontogramNew> PatientOdontogramNewGCToothNavigation { get; set; } = new List<PatientOdontogramNew>();

    [InverseProperty("GCToothProblemNavigation")]
    public virtual ICollection<PatientOdontogramNew> PatientOdontogramNewGCToothProblemNavigation { get; set; } = new List<PatientOdontogramNew>();

    [InverseProperty("GCOralMucosaNavigation")]
    public virtual ICollection<PatientOralMucosa> PatientOralMucosa { get; set; } = new List<PatientOralMucosa>();

    [InverseProperty("GCChronicityNavigation")]
    public virtual ICollection<PatientProblem> PatientProblemGCChronicityNavigation { get; set; } = new List<PatientProblem>();

    [InverseProperty("GCProblemStatusNavigation")]
    public virtual ICollection<PatientProblem> PatientProblemGCProblemStatusNavigation { get; set; } = new List<PatientProblem>();

    [InverseProperty("GCPatientStatusNavigation")]
    public virtual ICollection<PatientSurgeryStatus> PatientSurgeryStatusGCPatientStatusNavigation { get; set; } = new List<PatientSurgeryStatus>();

    [InverseProperty("GCStatusFromNavigation")]
    public virtual ICollection<PatientSurgeryStatus> PatientSurgeryStatusGCStatusFromNavigation { get; set; } = new List<PatientSurgeryStatus>();

    [InverseProperty("GCTransferFromNavigation")]
    public virtual ICollection<PatientSurgeryStatus> PatientSurgeryStatusGCTransferFromNavigation { get; set; } = new List<PatientSurgeryStatus>();

    [InverseProperty("GCTransferToNavigation")]
    public virtual ICollection<PatientSurgeryStatus> PatientSurgeryStatusGCTransferToNavigation { get; set; } = new List<PatientSurgeryStatus>();

    [InverseProperty("GCColorBlindnessNavigation")]
    public virtual ICollection<PatientVision> PatientVision { get; set; } = new List<PatientVision>();

    [InverseProperty("GCPaymentTypeNavigation")]
    public virtual ICollection<PaymentReceiptDt> PaymentReceiptDt { get; set; } = new List<PaymentReceiptDt>();

    [InverseProperty("GCReferenceTransferBankNavigation")]
    public virtual ICollection<PaymentRefund> PaymentRefund { get; set; } = new List<PaymentRefund>();

    [InverseProperty("GCReferenceTransferBankNavigation")]
    public virtual ICollection<PaymentRefundMedication> PaymentRefundMedication { get; set; } = new List<PaymentRefundMedication>();

    [InverseProperty("GCPeriodTypeNavigation")]
    public virtual ICollection<PayrollPeriodHd> PayrollPeriodHd { get; set; } = new List<PayrollPeriodHd>();

    [InverseProperty("GCAGCEmployeeNavigation")]
    public virtual ICollection<PayrollProcessSubDt> PayrollProcessSubDt { get; set; } = new List<PayrollProcessSubDt>();

    [InverseProperty("GCPemakaianAlatMedisNavigation")]
    public virtual ICollection<PemeriksaanInfeksiHd> PemeriksaanInfeksiHdGCPemakaianAlatMedisNavigation { get; set; } = new List<PemeriksaanInfeksiHd>();

    [InverseProperty("GCPosisiPasangNavigation")]
    public virtual ICollection<PemeriksaanInfeksiHd> PemeriksaanInfeksiHdGCPosisiPasangNavigation { get; set; } = new List<PemeriksaanInfeksiHd>();

    [InverseProperty("GCPhysicianTypeNavigation")]
    public virtual ICollection<PhysicianTeam> PhysicianTeam { get; set; } = new List<PhysicianTeam>();

    [InverseProperty("GCSurgeryParamedicTypeNavigation")]
    public virtual ICollection<PhysicianTeamSurgery> PhysicianTeamSurgery { get; set; } = new List<PhysicianTeamSurgery>();

    [InverseProperty("GCMemberNavigation")]
    public virtual ICollection<PraProcessDt> PraProcessDt { get; set; } = new List<PraProcessDt>();

    [InverseProperty("GCPaymentTypeNavigation")]
    public virtual ICollection<PrescriptionPayment> PrescriptionPayment { get; set; } = new List<PrescriptionPayment>();

    [InverseProperty("GCDrugTypeNavigation")]
    public virtual ICollection<PrescriptionTemplateDt> PrescriptionTemplateDtGCDrugTypeNavigation { get; set; } = new List<PrescriptionTemplateDt>();

    [InverseProperty("GCFrequencyNavigation")]
    public virtual ICollection<PrescriptionTemplateDt> PrescriptionTemplateDtGCFrequencyNavigation { get; set; } = new List<PrescriptionTemplateDt>();

    [InverseProperty("GCOrderTypeNavigation")]
    public virtual ICollection<PrescriptionTemplateDt> PrescriptionTemplateDtGCOrderTypeNavigation { get; set; } = new List<PrescriptionTemplateDt>();

    [InverseProperty("GCRouteNavigation")]
    public virtual ICollection<PrescriptionTemplateDt> PrescriptionTemplateDtGCRouteNavigation { get; set; } = new List<PrescriptionTemplateDt>();

    [InverseProperty("GCSignaNavigation")]
    public virtual ICollection<PrescriptionTemplateDt> PrescriptionTemplateDtGCSignaNavigation { get; set; } = new List<PrescriptionTemplateDt>();

    [InverseProperty("GCReasonOutNavigation")]
    public virtual ICollection<ProductionDt> ProductionDt { get; set; } = new List<ProductionDt>();

    [InverseProperty("GCReasonInNavigation")]
    public virtual ICollection<ProductionHd> ProductionHd { get; set; } = new List<ProductionHd>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<PurchaseOrderHd> PurchaseOrderHd { get; set; } = new List<PurchaseOrderHd>();

    [InverseProperty("GCFormTypeNavigation")]
    public virtual ICollection<QuestionaireForm> QuestionaireForm { get; set; } = new List<QuestionaireForm>();

    [InverseProperty("GCRL4TypeNavigation")]
    public virtual ICollection<RL4DataKetenagaan> RL4DataKetenagaan { get; set; } = new List<RL4DataKetenagaan>();

    [InverseProperty("GCRL6TypeNavigation")]
    public virtual ICollection<RL6InfeksiNosokomial> RL6InfeksiNosokomial { get; set; } = new List<RL6InfeksiNosokomial>();

    [InverseProperty("GCRLTypeNavigation")]
    public virtual ICollection<RLReportTemplate> RLReportTemplate { get; set; } = new List<RLReportTemplate>();

    [InverseProperty("GCReceivedUnplannedTypeNavigation")]
    public virtual ICollection<ReceivedUnplannedHd> ReceivedUnplannedHd { get; set; } = new List<ReceivedUnplannedHd>();

    [InverseProperty("GCTransactionTypeNavigation")]
    public virtual ICollection<ReconciliationDt> ReconciliationDt { get; set; } = new List<ReconciliationDt>();

    [InverseProperty("GCProviderNavigation")]
    public virtual ICollection<ReconciliationHd> ReconciliationHd { get; set; } = new List<ReconciliationHd>();

    [InverseProperty("GCReferralTypeNavigation")]
    public virtual ICollection<Referral> Referral { get; set; } = new List<Referral>();

    [InverseProperty("GCReferralTypeNavigation")]
    public virtual ICollection<ReferralPatient> ReferralPatient { get; set; } = new List<ReferralPatient>();

    [InverseProperty("GCDependentTypeNavigation")]
    public virtual ICollection<Registration> RegistrationGCDependentTypeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("GCDischargeConditionNavigation")]
    public virtual ICollection<Registration> RegistrationGCDischargeConditionNavigation { get; set; } = new List<Registration>();

    [InverseProperty("GCDischargeMethodNavigation")]
    public virtual ICollection<Registration> RegistrationGCDischargeMethodNavigation { get; set; } = new List<Registration>();

    [InverseProperty("GCERCaseTypeNavigation")]
    public virtual ICollection<Registration> RegistrationGCERCaseTypeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("GCOriginOfPatientRegNavigation")]
    public virtual ICollection<Registration> RegistrationGCOriginOfPatientRegNavigation { get; set; } = new List<Registration>();

    [InverseProperty("GCPatientCategoryNavigation")]
    public virtual ICollection<Registration> RegistrationGCPatientCategoryNavigation { get; set; } = new List<Registration>();

    [InverseProperty("GCPatientInTypeNavigation")]
    public virtual ICollection<Registration> RegistrationGCPatientInTypeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("GCReferralTypeNavigation")]
    public virtual ICollection<Registration> RegistrationGCReferralTypeNavigation { get; set; } = new List<Registration>();

    [InverseProperty("GCShift")]
    public virtual ICollection<Registration> RegistrationGCShift { get; set; } = new List<Registration>();

    [InverseProperty("GCTriageNavigation")]
    public virtual ICollection<Registration> RegistrationGCTriageNavigation { get; set; } = new List<Registration>();

    [InverseProperty("GCCreditTermsNavigation")]
    public virtual ICollection<RequestForProposalDt> RequestForProposalDt { get; set; } = new List<RequestForProposalDt>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<RequestForProposalHd> RequestForProposalHd { get; set; } = new List<RequestForProposalHd>();

    [InverseProperty("GCReturnToSupplierTypeNavigation")]
    public virtual ICollection<ReturnToSupplierHd> ReturnToSupplierHd { get; set; } = new List<ReturnToSupplierHd>();

    [InverseProperty("GCOccursNavigation")]
    public virtual ICollection<SalaryComponent> SalaryComponentGCOccursNavigation { get; set; } = new List<SalaryComponent>();

    [InverseProperty("GCSalaryComponentTaxNavigation")]
    public virtual ICollection<SalaryComponent> SalaryComponentGCSalaryComponentTaxNavigation { get; set; } = new List<SalaryComponent>();

    [InverseProperty("GCSalaryGroupNavigation")]
    public virtual ICollection<SalaryComponent> SalaryComponentGCSalaryGroupNavigation { get; set; } = new List<SalaryComponent>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<ServiceOrderRequestHd> ServiceOrderRequestHd { get; set; } = new List<ServiceOrderRequestHd>();

    [InverseProperty("GCCategoryNavigation")]
    public virtual ICollection<SiklusMenuDt> SiklusMenuDt { get; set; } = new List<SiklusMenuDt>();

    [InverseProperty("GCSiteGroupNavigation")]
    public virtual ICollection<Site> Site { get; set; } = new List<Site>();

    [InverseProperty("GCSpecialtyGroupNavigation")]
    public virtual ICollection<Specialty> Specialty { get; set; } = new List<Specialty>();

    [InverseProperty("GCLensTypeNavigation")]
    public virtual ICollection<SpectaclePrescription> SpectaclePrescriptionGCLensTypeNavigation { get; set; } = new List<SpectaclePrescription>();

    [InverseProperty("GCSpectaclePrescNavigation")]
    public virtual ICollection<SpectaclePrescription> SpectaclePrescriptionGCSpectaclePrescNavigation { get; set; } = new List<SpectaclePrescription>();

    [InverseProperty("GCSpectacleTypeNavigation")]
    public virtual ICollection<SpectaclePrescription> SpectaclePrescriptionGCSpectacleTypeNavigation { get; set; } = new List<SpectaclePrescription>();

    [InverseProperty("CostTypeNavigation")]
    public virtual ICollection<StandardCostVsActualCost> StandardCostVsActualCost { get; set; } = new List<StandardCostVsActualCost>();

    [InverseProperty("GCAdjustmentTypeNavigation")]
    public virtual ICollection<StockAdjustmentHd> StockAdjustmentHd { get; set; } = new List<StockAdjustmentHd>();

    [InverseProperty("GCItemTypeNavigation")]
    public virtual ICollection<StockTakingHd> StockTakingHd { get; set; } = new List<StockTakingHd>();

    [InverseProperty("GCSupplierTypeNavigation")]
    public virtual ICollection<Supplier> Supplier { get; set; } = new List<Supplier>();

    [InverseProperty("GCSurgeryParamedicTypeNavigation")]
    public virtual ICollection<SurgeryTeamTemplateDt> SurgeryTeamTemplateDt { get; set; } = new List<SurgeryTeamTemplateDt>();

    [InverseProperty("GCReasonOutNavigation")]
    public virtual ICollection<TemplateProductionDt> TemplateProductionDt { get; set; } = new List<TemplateProductionDt>();

    [InverseProperty("GCReasonInNavigation")]
    public virtual ICollection<TemplateProductionHd> TemplateProductionHd { get; set; } = new List<TemplateProductionHd>();

    [InverseProperty("GCTemplateGroupNavigation")]
    public virtual ICollection<TemplateText> TemplateText { get; set; } = new List<TemplateText>();

    [InverseProperty("GCToothStatusNavigation")]
    public virtual ICollection<ToothStatusRule> ToothStatusRuleGCToothStatusNavigation { get; set; } = new List<ToothStatusRule>();

    [InverseProperty("ValidGCToothStatusNavigation")]
    public virtual ICollection<ToothStatusRule> ToothStatusRuleValidGCToothStatusNavigation { get; set; } = new List<ToothStatusRule>();

    [InverseProperty("GCVaccinationStatusNavigation")]
    public virtual ICollection<VaccinationShotDt> VaccinationShotDt { get; set; } = new List<VaccinationShotDt>();

    [InverseProperty("GCFundingSourceNavigation")]
    public virtual ICollection<VaccinationShotSubDt> VaccinationShotSubDtGCFundingSourceNavigation { get; set; } = new List<VaccinationShotSubDt>();

    [InverseProperty("GCInjectionSiteNavigation")]
    public virtual ICollection<VaccinationShotSubDt> VaccinationShotSubDtGCInjectionSiteNavigation { get; set; } = new List<VaccinationShotSubDt>();

    [InverseProperty("GCVaccinationGroupNavigation")]
    public virtual ICollection<VaccinationType> VaccinationType { get; set; } = new List<VaccinationType>();

    [InverseProperty("GCReasonToViewEMRNavigation")]
    public virtual ICollection<ViewEMRLog> ViewEMRLog { get; set; } = new List<ViewEMRLog>();

    [InverseProperty("GCValueCode")]
    public virtual ICollection<VitalSignType> VitalSignType { get; set; } = new List<VitalSignType>();

    [InverseProperty("GCWorkCenterNavigation")]
    public virtual ICollection<WorkStation> WorkStation { get; set; } = new List<WorkStation>();

    [InverseProperty("GCProvinceNavigation")]
    public virtual ICollection<ZipCodes> ZipCodes { get; set; } = new List<ZipCodes>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<sysCHDRiskChart> sysCHDRiskChart { get; set; } = new List<sysCHDRiskChart>();

    [InverseProperty("GCSexNavigation")]
    public virtual ICollection<sysGrowthChartPoint> sysGrowthChartPoint { get; set; } = new List<sysGrowthChartPoint>();

    [InverseProperty("GCBusinessObjectNavigation")]
    public virtual sysTagField? sysTagField { get; set; }
}
