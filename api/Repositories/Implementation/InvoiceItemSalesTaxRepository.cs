using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class InvoiceItemSalesTaxRepository : RepositoryBase<InvoiceItemSalesTax>, IInvoiceItemSalesTaxRepository
    {
        public InvoiceItemSalesTaxRepository(AppDbContext context) : base(context)
        {
        }
    }
}
