using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Viewmodels
{
    public class ManufacturersViewModel : BaseViewModel<Manufacturers>, IBaseViewModel<ManufacturersViewModel>
    {
        public ManufacturersViewModel(Manufacturers model) : base(model)
        {
        }

        public ManufacturersViewModel CreateViewModel()
        {
            return this;
        }
    }
}
