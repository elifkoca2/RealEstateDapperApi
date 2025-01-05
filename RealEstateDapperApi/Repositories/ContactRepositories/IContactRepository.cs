using RealEstateDapperApi.Dtos.ContactDtos;
using RealEstateDapperApi.Dtos.ProductDtos;

namespace RealEstateDapperApi.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        Task CreateContact(CreateContactDto createContactDto);
        Task DeleteContact(int id);
        Task<GetByIDContactDto> GetContact(int id);
    }
}
