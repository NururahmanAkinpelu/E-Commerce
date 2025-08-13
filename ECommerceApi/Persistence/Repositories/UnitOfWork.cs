using Application.Interface.Repositories;

namespace Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceDbContext _context;

        public IUserRepository User { get;}
        public ICartRepository Cart { get; }
        public IProductRepository Product { get; }

        public UnitOfWork(ECommerceDbContext context, IUserRepository userRepository, 
            ICartRepository cartRepository, IProductRepository productRepository)
        {
            _context = context;
            User = userRepository;
            Cart = cartRepository;
            Product = productRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }


    }
}
