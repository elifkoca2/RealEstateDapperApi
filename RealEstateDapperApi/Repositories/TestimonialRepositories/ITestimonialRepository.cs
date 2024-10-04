using RealEstateDapperApi.Dtos.TestimonialDtos;

namespace RealEstateDapperApi.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
