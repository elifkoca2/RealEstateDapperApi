using RealEstateDapperApi.Dtos.MessageDtos;

namespace RealEstateDapperApi.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id);
    }
}
