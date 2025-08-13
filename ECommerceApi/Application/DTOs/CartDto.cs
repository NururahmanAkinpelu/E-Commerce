using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CartDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<CartProductDto> CartProducts { get; set; } = new List<CartProductDto>();
        public decimal TotalPrice { get; set; }
    }

    public class CartRequest
    {
        public Guid UserId { get; set; }
        public List<CartProductRequest> CartProducts { get; set; } = new List<CartProductRequest>();
    }

    public class CartUpdateRequest
    {
        public Guid UserId { get; set; }
        public List<CartProductRequest> CartProducts { get; set; } = new List<CartProductRequest>();
    }

    public class CartProductRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class CartProductDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
