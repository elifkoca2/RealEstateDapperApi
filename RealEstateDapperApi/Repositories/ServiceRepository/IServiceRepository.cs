using RealEstateDapperApi.Dtos.ServiceDtos;

namespace RealEstateDapperApi.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto createServiceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateServiceDto);
        Task<GetByIDServiceDto> GetService(int id);
    }
}
