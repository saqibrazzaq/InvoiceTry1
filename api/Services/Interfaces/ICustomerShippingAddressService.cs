using api.Dtos;

namespace api.Services.Interfaces
{
    public interface ICustomerShippingAddressService
    {
        CustomerShippingAddressRes? Get(int customerShippingAddressId);
        CustomerShippingAddressRes? Create(CustomerShippingAddressReqEdit dto);
        CustomerShippingAddressRes? Update(int customerShippingAddressId, CustomerShippingAddressReqEdit dto);
        void Delete(int customerShippingAddressId);
    }
}
