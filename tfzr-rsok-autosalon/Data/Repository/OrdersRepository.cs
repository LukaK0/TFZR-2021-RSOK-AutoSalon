using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Models;

namespace tfzr_rsok_autosalon.Data.Repository
{
    public class OrdersRepository : Repository<Orders>, IOrdersRepository
    {
        private readonly ApplicationDbContext _context;

        public OrdersRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}