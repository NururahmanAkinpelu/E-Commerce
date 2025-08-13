using Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Repositories
{
    public interface ICartRepository : IRepositoryAsync<Cart>
    {
        Task<Cart> GetCart(Expression<Func<Cart, bool>> expression);
        Task<IEnumerable<Cart>> GetCarts(Expression<Func<Cart, bool>> expression);
    }
}
