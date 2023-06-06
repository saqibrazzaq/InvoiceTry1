using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class ServiceSalesTaxRepository : RepositoryBase<ServiceSalesTax>, IServiceSalesTaxRepository
    {
        public ServiceSalesTaxRepository(AppDbContext context) : base(context)
        {
        }
    }
}
