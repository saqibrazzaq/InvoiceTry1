using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class CustomerShippingAddressRepository : RepositoryBase<CustomerShippingAddress>, ICustomerShippingAddressRepository
    {
        public CustomerShippingAddressRepository(AppDbContext context) : base(context)
        {
        }
    }
}
