using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IBusinessService
    {
        BusinessRes? Get(int businessId);
        BusinessRes? Create(BusinessReqEdit dto);
        BusinessRes? Update(int businessId, BusinessReqEdit dto);
        void Delete(int businessId);
    }
}
