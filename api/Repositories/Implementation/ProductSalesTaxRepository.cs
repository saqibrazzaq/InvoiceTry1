using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class ProductSalesTaxRepository : RepositoryBase<ProductSalesTax>, IProductSalesTaxRepository
    {
        public ProductSalesTaxRepository(AppDbContext context) : base(context)
        {
        }
    }
}
