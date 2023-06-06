using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class BillItemSalesTaxRepository : RepositoryBase<BillItemSalesTax>, IBillItemSalesTaxRepository
    {
        public BillItemSalesTaxRepository(AppDbContext context) : base(context)
        {
        }
    }
}
