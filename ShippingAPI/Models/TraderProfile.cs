using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShippingAPI.Models
{
    public class TraderProfile
    {
        [Key]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        [Required]
        public string StoreName { get; set; }

        [Required]
        public string Governorate { get; set; }

        [Required]
        public string City { get; set; }

        public decimal CustomPickupCost { get; set; }

        [Range(0, 100)]
        public decimal RejectedOrderShippingShare { get; set; }
    }
}
