using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IProductSalesTaxService
    {
        ProductSalesTaxRes? Get(int productSalesTaxId);
        ProductSalesTaxRes? Create(ProductSalesTaxReqEdit dto);
        ProductSalesTaxRes? Update(int productSalesTaxId, ProductSalesTaxReqEdit dto);
        void Delete(int productSalesTaxId);
    }
}
