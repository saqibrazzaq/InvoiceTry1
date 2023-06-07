using api.Dtos;

namespace api.Services.Interfaces
{
    public interface ISalesTaxService
    {
        SalesTaxRes? Get(int salesTaxId);
        SalesTaxRes? Create(SalesTaxReqEdit dto);
        SalesTaxRes? Update(int salesTaxId, SalesTaxReqEdit dto);
        void Delete(int salesTaxId);
    }
}
