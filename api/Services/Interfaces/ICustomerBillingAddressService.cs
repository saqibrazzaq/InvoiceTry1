using api.Dtos;

namespace api.Services.Interfaces
{
    public interface ICustomerBillingAddressService
    {
        CustomerBillingAddressRes? Get(int customerBillindAddressId);
        CustomerBillingAddressRes? Create(CustomerBillingAddressReqEdit dto);
        CustomerBillingAddressRes? Update(int customerBillindAddressId, CustomerBillingAddressReqEdit dto);
        void Delete(int customerBillindAddressId);
    }
}
