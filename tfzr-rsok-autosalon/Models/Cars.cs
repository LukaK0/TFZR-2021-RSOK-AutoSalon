using System.ComponentModel.DataAnnotations.Schema;

namespace tfzr_rsok_autosalon.Models
{
    public class Cars : BaseModel
    {
        [ForeignKey("ManufacturersId")]
        public virtual Manufacturers Manufacturers { get; set; }
        public int ManufacturersId { get; set; }

        [ForeignKey("CarModelId")]
        public virtual CarModels CarModels { get; set; }
        public int CarModelId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Categorizes Categorizes { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public long HorsePower { get; set; }
        public long Torque { get; set; }
        public int NumberOfDoors { get; set; }
        public override bool IsModelValid()
        {
            return true;
        }
    }
}