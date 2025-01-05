using RealEstateDapperApi.Dtos.ToDoListDtos;

namespace RealEstateDapperApi.Repositories.ToDoListRepositories
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoList();
        Task CreateToDoList(CreateToDoListDto ToDoListDto);
        Task DeleteToDoList(int id);
        Task UpdateToDoList(UptadeToDoListDto ToDoListDto);
        Task<GetByIDToDoListDto> GetToDoList(int id);
    }
}
