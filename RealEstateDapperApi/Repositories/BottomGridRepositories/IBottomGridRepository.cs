using RealEstateDapperApi.Dtos.BottomGridDtos;
using RealEstateDapperApi.Dtos.ServiceDtos;

namespace RealEstateDapperApi.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
