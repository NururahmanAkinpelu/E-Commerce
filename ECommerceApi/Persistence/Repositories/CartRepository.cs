using Application.Interface.Repositories;
using Domain.Entitties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class CartRepository : RepositoryAsync<Cart>, ICartRepository
    {
        private readonly ECommerceDbContext _context;
        public CartRepository(ECommerceDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Cart> GetCart(Expression<Func<Cart, bool>> expression)
        {
            var cart = await _context.Carts.Include(x => x.CartProducts).ThenInclude(x => x.Product).FirstOrDefaultAsync(expression);
            return cart;
        }
        public async Task<IEnumerable<Cart>> GetCarts(Expression<Func<Cart, bool>> expression)
        {
            return await _context.Carts.Include(x => x.CartProducts).ThenInclude(x => x.Product).Where(expression).ToListAsync();
        }
    }
}
