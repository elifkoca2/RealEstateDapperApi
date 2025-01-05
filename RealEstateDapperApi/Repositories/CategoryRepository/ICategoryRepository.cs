using RealEstateDapperApi.Dtos.CategoryDtos;

namespace RealEstateDapperApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategory();
        Task CreateCategory (CreateCategoryDto categoryDto);
        Task DeleteCategory(int id);
        Task UpdateCategory (UpdateCategoryDto categoryDto);
        Task<GetByIDCategoryDto> GetCategory(int id );
    }
}