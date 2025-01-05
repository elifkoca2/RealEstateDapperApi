 using RealEstateDapperApi.Dtos.CategoryDtos;
using RealEstateDapperApi.Dtos.EmployeeDtos;

namespace RealEstateDapperApi.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployee();
        Task CreateEmployee(CreateEmployeeDto createEmployeeDto);
        Task DeleteEmployee(int id);
        Task UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
        Task<GetByIDEmployeeDto> GetEmployee(int id);
    }
}
