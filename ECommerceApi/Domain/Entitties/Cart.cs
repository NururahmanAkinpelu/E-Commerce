using Domain.Entitties.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitties
{
    public class Cart : AuditableEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<CartProduct> CartProducts { get; set; } = new List<CartProduct>();
        public decimal TotalPrice { get; set; }
    }
}
