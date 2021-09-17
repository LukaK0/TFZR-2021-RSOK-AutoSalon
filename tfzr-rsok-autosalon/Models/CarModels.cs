using System.ComponentModel.DataAnnotations.Schema;

namespace tfzr_rsok_autosalon.Models
{
    public class CarModels : BaseModel
    {
        public string Name { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Categorizes Category { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("ManufacturerId")]
        public virtual Manufacturers Manufacturer { get; set; }
        public int ManufacturerId { get; set; }

        public override bool IsModelValid()
        {
            return !string.IsNullOrEmpty(Name);
        }
    }
}