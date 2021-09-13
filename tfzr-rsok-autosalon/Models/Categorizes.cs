using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tfzr_rsok_autosalon.Models
{
    public class Categorizes : BaseModel
    {
        public string Name { get; set; }
        public override bool IsModelValid()
        {
            return !string.IsNullOrEmpty(Name);
        }
    }
}
