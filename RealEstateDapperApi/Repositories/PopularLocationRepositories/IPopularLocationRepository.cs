using RealEstateDapperApi.Dtos.BottomGridDtos;
using RealEstateDapperApi.Dtos.PopularLocationDtos;
using RealEstateDapperApi.Dtos.PopularLocationDtos;

namespace RealEstateDapperApi.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocation();
        Task CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        Task DeletePopularLocation(int id);
        Task UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIDPopularLocationDto> GetPopularLocation(int id);
    }
}
