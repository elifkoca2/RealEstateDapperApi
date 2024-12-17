using Microsoft.AspNetCore.Mvc;
using RealEstateDapperApi.Repositories.ToDoListRepositories;

namespace RealEstateDapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
         private readonly IToDoListRepository _ToDoListRepository;

        public ToDoListsController(IToDoListRepository ToDoListRepository)
        {
            _ToDoListRepository = ToDoListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ToDoListList()
        {
            var values = await _ToDoListRepository.GetAllToDoListAsync();
            return Ok(values);
        }
    }
}
