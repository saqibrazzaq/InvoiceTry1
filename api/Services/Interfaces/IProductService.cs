using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IProductService
    {
        ProductRes? Get(int productId);
        ProductRes? Create(ProductReqEdit dto);
        ProductRes? Update(int productId, ProductReqEdit dto);
        void Delete(int productId);
    }
}
