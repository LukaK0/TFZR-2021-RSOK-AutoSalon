using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Viewmodels
{
    public class OrdersViewModel : BaseViewModel<Orders>, IBaseViewModel<OrdersViewModel>
    {
        public OrdersViewModel(Orders model) : base(model)
        {
        }

        public OrdersViewModel CreateViewModel()
        {
            return this;
        }
    }
}
