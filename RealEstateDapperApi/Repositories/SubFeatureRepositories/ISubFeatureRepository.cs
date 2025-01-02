using RealEstateDapperApi.Dtos.SubFeatureDtos;

namespace RealEstateDapperApi.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();

    }
}
