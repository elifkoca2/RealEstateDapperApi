using RealEstateDapperApi.Dtos.AppUserDtos;

namespace RealEstateDapperApi.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id);

    }
}
