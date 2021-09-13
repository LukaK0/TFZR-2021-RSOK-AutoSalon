using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels;

namespace tfzr_rsok_autosalon.Data.Repository.IRepository
{
    public interface IOrdersRepository : IRepository<Orders>
    {
        public IEnumerable<OrdersViewModel> GetAll();
    }
}
