using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels;

namespace tfzr_rsok_autosalon.Data.Repository
{
    public class OrdersRepository : Repository<Orders>, IOrdersRepository
    {
        private readonly ApplicationDbContext _context;

        public OrdersRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<OrdersViewModel> GetAll()
        {
            return _context.Orders.Include(x => x.Car)
                .Select(x=> new OrdersViewModel(x));
        }
    }
}