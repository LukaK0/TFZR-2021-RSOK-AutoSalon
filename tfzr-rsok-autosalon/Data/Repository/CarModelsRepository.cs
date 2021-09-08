using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Models;

namespace tfzr_rsok_autosalon.Data.Repository
{
    public class CarModelsRepository : Repository<CarModels>, ICarModelsRepository
    {
        private readonly ApplicationDbContext _context;

        public CarModelsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}