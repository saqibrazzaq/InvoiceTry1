using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
