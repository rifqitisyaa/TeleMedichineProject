using TeleMedichineProject.Models.DTO;

namespace TeleMedichineProject.Services
{
    public interface ITariffService
    {
        Task<TariffDto> GetTariffAsync(TariffRequest req);
        Task<TariffDto> GetTariffHomeCareAsync(TariffRequest req);
        Task<TariffDto?> GetTariffWalkInAsync(TariffRequest req);
        Task<TariffDto?> GetTariffWalkInCorporateAsync(TariffRequest req);
        Task<TariffDto?> GetTariffMCUAsync(TariffRequest req);
    }
}
