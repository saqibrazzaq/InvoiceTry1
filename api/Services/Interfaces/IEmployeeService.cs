using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeRes? Get(int employeeId);
        EmployeeRes? Create(EmployeeReqEdit dto);
        EmployeeRes? Update(int employeeId, EmployeeReqEdit dto);
        void Delete(int employeeId);
    }
}
