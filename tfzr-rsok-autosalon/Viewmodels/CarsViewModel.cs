using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Viewmodels
{
    public class CarsViewModel : BaseViewModel<Cars>, IBaseViewModel<CarsViewModel>, IBaseViewModel<Cars>
    {
        public CarsViewModel(Cars model) : base(model)
        {
        }

        public CarsViewModel CreateViewModel()
        {
            return this;
        }

        Cars IBaseViewModel<Cars>.CreateViewModel()
        {
            return this.Model;
        }
    }
}
