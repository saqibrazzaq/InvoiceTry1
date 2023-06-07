using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IBillService
    {
        BillRes? Get(int billId);
        BillRes? Create(BillReqEdit dto);
        BillRes? Update(int billId, BillReqEdit dto);
        void Delete(int billId);
    }
}
