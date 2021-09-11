using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using tfzr_rsok_autosalon.Data.Repository.IRepository;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Services.IServices;
using tfzr_rsok_autosalon.Viewmodels;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _repository;
        private readonly ICarsRepository _cars;

        public OrdersService(IOrdersRepository repository, ICarsRepository cars)
        {
            _repository = repository;
            _cars = cars;
        }
        public IEnumerable<OrdersViewModel> GetAll()
        {
            return _repository.GetAll(includeProperties: "Cars, IdentityUser").Select(x => new OrdersViewModel(x).CreateViewModel());
        }

        public SelectList GetCarForDropDown()
        {

            return new SelectList(_cars.GetAll(), nameof(Cars.Id), nameof(Cars.Description));
        }

        public SelectList GetUserForDropDown()
        {
            throw new NotImplementedException();
        }

        public IBaseViewModel<Orders> Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Orders model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Orders model)
        {
            _repository.Add(model);
        }

        IBaseViewModel<Orders> IService<Orders, IBaseViewModel<Orders>>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
