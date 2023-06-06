using api.Data;
using api.Entities;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class BillItemRepository : RepositoryBase<BillItem>, IBillItemRepository
    {
        public BillItemRepository(AppDbContext context) : base(context)
        {
        }
    }
}
