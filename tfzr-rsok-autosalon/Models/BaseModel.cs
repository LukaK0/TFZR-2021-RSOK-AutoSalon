using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tfzr_rsok_autosalon.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public abstract bool IsModelValid();
    }
}
