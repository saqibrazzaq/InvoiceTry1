using api.Dtos;

namespace api.Services.Interfaces
{
    public interface ICustomerContactService
    {
        CustomerContactRes? Get(int customerContactId);
        CustomerContactRes? Create(CustomerContactReqEdit dto);
        CustomerContactRes? Update(int customerContactId, CustomerContactReqEdit dto);
        void Delete(int customerContactId);
    }
}
