using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IAddressService
    {
        AddressRes? Get(int addressId);
        AddressRes? Create(AddressReqEdit dto);
        AddressRes? Update(int addressId, AddressReqEdit dto);
        void Delete(int addressId);
    }
}
