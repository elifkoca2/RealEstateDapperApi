using RealEstateDapperApi.Dtos.BottomGridDtos;
using RealEstateDapperApi.Dtos.ServiceDtos;

namespace RealEstateDapperApi.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGrid();
        Task CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        Task DeleteBottomGrid(int id);
        Task UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
