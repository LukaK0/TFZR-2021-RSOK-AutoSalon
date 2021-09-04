using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tfzr_rsok_autosalon.Models
{
    public class Manufacturers : BaseModel
    {
        public string Name { get; set; }
        public override bool IsModelValid()
        {
            throw new System.NotImplementedException();
        }
    }
}
