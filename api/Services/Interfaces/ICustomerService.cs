using api.Dtos;

namespace api.Services.Interfaces
{
    public interface ICustomerService
    {
        CustomerRes? Get(int customerId);
        CustomerRes? Create(CustomerReqEdit dto);
        CustomerRes? Update(int customerId, CustomerReqEdit dto);
        void Delete(int customerId);
    }
}
