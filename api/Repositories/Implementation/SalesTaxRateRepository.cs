using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class SalesTaxRateRepository : RepositoryBase<SalesTaxRate>, ISalesTaxRateRepository
    {
        public SalesTaxRateRepository(AppDbContext context) : base(context)
        {
        }
    }
}
