using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ShippingAPI.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }

        // Branch افتراضي (لو عنده واحد رئيسي فقط)
        public string Branch { get; set; }

        // Navigation
        public virtual AdminProfile AdminProfile { get; set; }
        public virtual TraderProfile TraderProfile { get; set; }
        public virtual CourierProfile CourierProfile { get; set; }
        public virtual ICollection<AccountTransaction> AccountTransactions { get; set; } = new List<AccountTransaction>();


    }
}
