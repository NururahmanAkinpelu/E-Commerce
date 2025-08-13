using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        ICartRepository Cart { get; }
        Task<int> SaveChangesAsync();
    }
}
