using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IDesignationService
    {
        DesignationRes? Get(int designationId);
        DesignationRes? Create(DesignationReqEdit dto);
        DesignationRes? Update(int designationId, DesignationReqEdit dto);
        void Delete(int designationId);
    }
}
