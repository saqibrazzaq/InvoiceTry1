using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class SalesTaxRepository : RepositoryBase<SalesTax>, ISalesTaxRepository
    {
        public SalesTaxRepository(AppDbContext context) : base(context)
        {
        }
    }
}
