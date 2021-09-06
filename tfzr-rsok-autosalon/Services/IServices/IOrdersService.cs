using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Services.IServices
{
    public interface IOrdersService : IService<Orders, IBaseViewModel<Orders>>
    {
        IEnumerable<OrdersViewModel> GetAll();
        SelectList GetUserForDropDown();
        SelectList GetCarForDropDown();
    }
}
