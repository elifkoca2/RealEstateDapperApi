using RealEstateDapperApi.Dtos.PropertyAmenityDtos;

namespace RealEstateDapperApi.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id);
    }
}
