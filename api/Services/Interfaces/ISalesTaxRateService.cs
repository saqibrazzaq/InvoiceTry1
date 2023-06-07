using api.Dtos;

namespace api.Services.Interfaces
{
    public interface ISalesTaxRateService
    {
        SalesTaxRateRes? Get(int salesTaxRateId);
        SalesTaxRateRes? Create(SalesTaxRateReqEdit dto);
        SalesTaxRateRes? Update(int salesTaxRateId, SalesTaxRateReqEdit dto);
        void Delete(int salesTaxRateId);
    }
}
