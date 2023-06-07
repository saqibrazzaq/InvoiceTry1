using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IDepartmentService
    {
        DepartmentRes? Get(int departmentId);
        DepartmentRes? Create(DepartmentReqEdit dto);
        DepartmentRes? Update(int departmentId, DepartmentReqEdit dto);
        void Delete(int departmentId);
    }
}
