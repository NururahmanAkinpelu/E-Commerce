using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Services
{
    public interface IProductService
    {
        Task<Response<ProductDto>> AddProduct(ProductRequest product);
/*        Task<Response<ProductDto>> UpdateProduct(Guid id, ProductRequest product);
        Task<Response<ProductDto>> DeleteProduct(Guid id);*/
        Task<Response<ProductDto>> GetProduct(Guid id);
        Task<Response<IEnumerable<ProductDto>>> GetProducts();
    }
}
