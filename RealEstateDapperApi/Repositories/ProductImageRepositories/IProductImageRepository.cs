using RealEstateDapperApi.Dtos.ProductDetailDtos;
using RealEstateDapperApi.Dtos.ProductImageDtos;

namespace RealEstateDapperApi.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int id);

    }
}
