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
        public string? Branch { get; set; }
        public string? CurrentToken { get; set; }
        public DateTime? TokenExpiration { get; set; }
        public bool IsActive { get; set; } = true;
        // Navigation
        public virtual AdminProfile AdminProfile { get; set; }
        public virtual TraderProfile TraderProfile { get; set; }
        public virtual CourierProfile CourierProfile { get; set; }
        public virtual ICollection<AccountTransaction> AccountTransactions { get; set; } = new List<AccountTransaction>();


    }
}
