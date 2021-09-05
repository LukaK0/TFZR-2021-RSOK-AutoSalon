using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Services.IServices
{
    public interface ICategorizesService : IService<Categorizes, IBaseViewModel<Categorizes>>
    {
        IEnumerable<CategorizesViewModel> GetAll();
    }
}
