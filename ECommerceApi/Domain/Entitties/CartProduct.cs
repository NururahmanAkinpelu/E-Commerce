using Domain.Entitties.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitties
{
    public class CartProduct : AuditableEntity
    {
        public Guid CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
