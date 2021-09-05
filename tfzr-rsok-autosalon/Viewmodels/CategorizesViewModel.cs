using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Viewmodels
{
    public class CategorizesViewModel : BaseViewModel<Categorizes>, IBaseViewModel<CategorizesViewModel>
    {
        public CategorizesViewModel(Categorizes model) : base(model)
        {
        }

        public CategorizesViewModel CreateViewModel()
        {
            return this;
        }
    }
}
