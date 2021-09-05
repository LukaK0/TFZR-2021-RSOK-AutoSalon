using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Services.IServices
{
    public interface IService<T, O> where T : BaseModel where O : IBaseViewModel<T>
    {
        O GetAll();
        O Get(int id);
        void Update(T model);
        void Delete(int id);
        void Add(T model);
    }
}
