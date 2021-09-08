using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Models;

namespace tfzr_rsok_autosalon.Data.Repository
{
    public class ManufacturesRepository : Repository<Manufacturers>, IManufacturesRepository
    {
        private readonly ApplicationDbContext _context;

        public ManufacturesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}