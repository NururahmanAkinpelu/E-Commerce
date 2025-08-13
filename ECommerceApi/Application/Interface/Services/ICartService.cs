using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Services
{
    public interface ICartService
    {
        Task<Response<CartDto>> CreateCart(CartRequest cart);
        Task<Response<CartDto>> UpdateCart(Guid id, CartUpdateRequest cart);
        Task<Response<CartDto>> DeleteCart(Guid id);
        Task<Response<CartDto>> GetCart(Guid id);
        Task<Response<IEnumerable<CartDto>>> GetCarts();
        Task<Response<IEnumerable<CartDto>>> GetCartsByUserId(Guid userId);
    }
}
