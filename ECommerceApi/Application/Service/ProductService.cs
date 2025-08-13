using Application.DTOs;
using Application.Interface.Repositories;
using Application.Interface.Services;
using Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<ProductDto>> AddProduct(ProductRequest request)
        {
            var response = new Response<ProductDto>();
            var exist = await _unitOfWork.Product.ExistsAsync(x => x.Name.ToLower() == request.Name.ToLower());
            if (exist)
            {
                response.Success = false;
                response.Message = "Product already exists.";
                return response;
            }
            var product = new Product
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                StockQuantity = request.StockQuantity,
                Category = request.Category,
            };
            await _unitOfWork.Product.AddAsync(product);
            
            response.Success = true;
            response.Message = "Product added successfully.";
            response.Data = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                Category = product.Category
            };
            return response;
        }

        public async Task<Response<ProductDto>> GetProduct(Guid id)
        {
            var response = new Response<ProductDto>();
            var product = await _unitOfWork.Product.GetAsync(x => x.Id == id);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Product not found.";
                return response;
            }
            response.Success = true;
            response.Message = "Product retrieved successfully.";
            response.Data = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                Category = product.Category
            };
            return response;
        }

        public async Task<Response<IEnumerable<ProductDto>>> GetProducts()
        {
            var response = new Response<IEnumerable<ProductDto>>();
            var products = await _unitOfWork.Product.GetAllAsync();
            if (products == null || !products.Any())
            {
                response.Success = false;
                response.Message = "No products found.";
                return response;
            }
            response.Success = true;
            response.Message = "Products retrieved successfully.";
            response.Data = products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                Category = p.Category
            });
            return response;
        }
    }
}
