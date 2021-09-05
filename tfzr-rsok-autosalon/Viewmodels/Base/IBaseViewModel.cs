using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tfzr_rsok_autosalon.Viewmodels.Base
{
    public interface IBaseViewModel<out T> where T : class
    {
        public T CreateViewModel();
    }
}
