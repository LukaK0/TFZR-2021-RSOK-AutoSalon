using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace tfzr_rsok_autosalon.Models
{
    public class Orders : BaseModel
    {
        [ForeignKey("FK_Users_Orders")]
        public virtual IdentityUser User { get; set; }
        [ForeignKey("FK_Cars_Orders")]
        public virtual Cars Car { get; set; }

        [Column("FK_Users_Orders")]
        public Guid UserId { get; set; }
        [Column("FK_Cars_Orders")]
        public int CarId { get; set; }

        public int Status { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public override bool IsModelValid()
        {
            throw new NotImplementedException();
        }
    }
}