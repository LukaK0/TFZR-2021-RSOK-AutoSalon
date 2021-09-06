using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Viewmodels
{
    public class CarModelsViewModel : BaseViewModel<CarModels>, IBaseViewModel<CarModelsViewModel>
    {
        public CarModelsViewModel(CarModels model) : base(model)
        {
        }

        public CarModelsViewModel CreateViewModel()
        {
            return this;
        }
    }
}
