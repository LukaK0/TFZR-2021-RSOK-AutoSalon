using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Models;

namespace tfzr_rsok_autosalon.Data.Repository
{
    public class CategorizesRepository : Repository<Categorizes>, ICategorizesRepository
    {
        private readonly ApplicationDbContext _context;

        public CategorizesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}