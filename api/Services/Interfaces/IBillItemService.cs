using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IBillItemService
    {
        BillItemRes? Get(int billItemId);
        BillItemRes? Create(BillItemReqEdit dto);
        BillItemRes? Update(int billItemId, BillItemReqEdit dto);
        void Delete(int billItemId);
    }
}
