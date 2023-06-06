using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class VendorRepository : RepositoryBase<Vendor>, IVendorRepository
    {
        public VendorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
