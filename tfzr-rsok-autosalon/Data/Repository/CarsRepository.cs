using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Models;

namespace tfzr_rsok_autosalon.Data.Repository
{
    public class CarsRepository : Repository<Cars>, ICarsRepository
    {
        private readonly ApplicationDbContext _context;

        public CarsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}