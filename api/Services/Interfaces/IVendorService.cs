using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IVendorService
    {
        VendorRes? Get(int vendorId);
        VendorRes? Create(VendorReqEdit dto);
        VendorRes? Update(int vendorId, VendorReqEdit dto);
        void Delete(int vendorId);
    }
}
