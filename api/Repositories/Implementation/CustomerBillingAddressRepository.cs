using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class CustomerBillingAddressRepository : RepositoryBase<CustomerBillingAddress>, ICustomerBillingAddressRepository
    {
        public CustomerBillingAddressRepository(AppDbContext context) : base(context)
        {
        }
    }
}
