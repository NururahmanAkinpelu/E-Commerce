using Domain.Entitties.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitties
{
    public class User : AuditableEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public bool IsEmailVerified { get; set; } = false;
        public bool IsPhoneNumberVerified { get; set; } = false;
        public string? ProfilePictureUrl { get; set; }
        public string? Role { get; set; }
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
    }
}
