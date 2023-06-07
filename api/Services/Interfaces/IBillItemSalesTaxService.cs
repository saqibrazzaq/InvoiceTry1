using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IBillItemSalesTaxService
    {
        BillItemSalesTaxRes? Get(int billItemSalesTaxId);
        BillItemSalesTaxRes? Create(BillItemSalesTaxReqEdit dto);
        BillItemSalesTaxRes? Update(int billItemSalesTaxId, BillItemSalesTaxReqEdit dto);
        void Delete(int billItemSalesTaxId);
    }
}
