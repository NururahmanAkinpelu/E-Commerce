using Application.DTOs;
using Application.Interface.Repositories;
using Application.Interface.Services;
using Domain.Entitties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<CartDto>> CreateCart(CartRequest cartRequest)
        {
            var response = new Response<CartDto>();
            var exist = await _unitOfWork.Cart.ExistsAsync(x => x.UserId == cartRequest.UserId);
            if (exist)
            {
                response.Success = false;
                response.Message = "Cart already exists for this user.";
                return response;
            }
            var cart = new Cart
            {
                UserId = cartRequest.UserId,
                CartProducts = cartRequest.CartProducts.Select(item => new CartProduct
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                }).ToList(),
                TotalPrice = 0
            };

            foreach (var cartProduct in cart.CartProducts)
            {
                var product = await _unitOfWork.Product.GetAsync(x => x.Id == cartProduct.ProductId);
                if (product == null)
                {
                    response.Success = false;
                    response.Message = $"Product with ID {cartProduct.ProductId} not found.";
                    return response;
                }
                cart.TotalPrice += cartProduct.Quantity * product.Price;
            }
            await _unitOfWork.Cart.AddAsync(cart);
            response.Success = true;
            response.Message = "Cart created successfully.";
            response.Data = new CartDto
            {
                Id = cart.Id,
                UserId = cart.UserId,
                CartProducts = cart.CartProducts.Select(cp => new CartProductDto
                {
                    ProductId = cp.ProductId,
                    Quantity = cp.Quantity,
                    ProductName = cp.Product.Name,
                    Price = cp.Product.Price,
                    TotalPrice = cp.Quantity * cp.Product.Price
                }).ToList(),
                TotalPrice = cart.TotalPrice
            };
            return response;
        }

        public async Task<Response<CartDto>> UpdateCart(Guid id, CartUpdateRequest cartRequest)
        {
            var response = new Response<CartDto>();

            var cart = await _unitOfWork.Cart.GetCart(x => x.Id == id);
            if (cart == null)
            {
                response.Success = false;
                response.Message = "Cart not found.";
                return response;
            }

            foreach (var requestProduct in cartRequest.CartProducts)
            {

                var product = await _unitOfWork.Product.GetAsync(x => x.Id == requestProduct.ProductId);
                if (product == null)
                {
                    response.Success = false;
                    response.Message = $"Product with ID {requestProduct.ProductId} not found.";
                    return response;
                }

                var existingCartProduct = cart.CartProducts.FirstOrDefault(cp => cp.ProductId == requestProduct.ProductId);
                if (existingCartProduct != null)
                {
                    existingCartProduct.Quantity += requestProduct.Quantity;
                }
                else
                {
                    cart.CartProducts.Add(new CartProduct
                    {
                        ProductId = requestProduct.ProductId,
                        Quantity = requestProduct.Quantity,
                        Product = product
                    });
                }
            }

            cart.TotalPrice = cart.CartProducts.Sum(cp => cp.Quantity * cp.Product.Price);

            await _unitOfWork.Cart.UpdateAsync(cart);

            response.Success = true;
            response.Message = "Cart updated successfully.";
            response.Data = new CartDto
            {
                Id = cart.Id,
                UserId = cart.UserId,
                CartProducts = cart.CartProducts.Select(cp => new CartProductDto
                {
                    ProductId = cp.ProductId,
                    ProductName = cp.Product.Name,
                    Quantity = cp.Quantity,
                    Price = cp.Product.Price,
                    TotalPrice = cp.Quantity * cp.Product.Price
                }).ToList(),
                TotalPrice = cart.TotalPrice
            };

            return response;
        }

        public async Task<Response<CartDto>> DeleteCart(Guid id)
        {
            // Implementation for deleting a cart
            throw new NotImplementedException();
        }
        public async Task<Response<CartDto>> GetCart(Guid id)
        {

            var response = new Response<CartDto>();
            var cart = await _unitOfWork.Cart.GetAsync(x => x.Id == id);
            if (cart == null)
            {
                response.Success = false;
                response.Message = "Cart not found.";
                return response;
            }
            response.Success = true;
            response.Message = "Cart retrieved successfully.";
            response.Data = new CartDto
            {
                Id = cart.Id,
                UserId = cart.UserId,
                CartProducts = cart.CartProducts.Select(cp => new CartProductDto
                {
                    ProductId = cp.ProductId,
                    Quantity = cp.Quantity
                }).ToList(),
                TotalPrice = cart.CartProducts.Sum(cp => cp.Quantity * cp.Product.Price)
            };
            return response;
        }
        public async Task<Response<IEnumerable<CartDto>>> GetCartsByUserId(Guid userId)
        {

            var response = new Response<IEnumerable<CartDto>>();
            var carts = await _unitOfWork.Cart.GetCarts(x => x.UserId == userId);
            if (carts == null || !carts.Any())
            {
                response.Success = false;
                response.Message = "Cart not found.";
                return response;
            }
            response.Success = true;
            response.Message = "Cart retrieved successfully.";
            response.Data = carts.Select(cart => new CartDto
            {
                Id = cart.Id,
                UserId = cart.UserId,
                CartProducts = cart.CartProducts.Select(cp => new CartProductDto
                {
                    ProductId = cp.ProductId,
                    ProductName = cp.Product.Name,
                    Price = cp.Product.Price,
                    Quantity = cp.Quantity
                }).ToList(),
                TotalPrice = cart.CartProducts.Sum(cp => cp.Quantity * cp.Product.Price)
            }).ToList();
            return response;
        }
        public async Task<Response<IEnumerable<CartDto>>> GetCarts()
        {

            var response = new Response<IEnumerable<CartDto>>();
            var carts = await _unitOfWork.Cart.GetAllAsync();
            if (carts == null || !carts.Any())
            {
                response.Success = false;
                response.Message = "No carts found.";
                return response;
            }
            response.Success = true;
            response.Message = "Carts retrieved successfully.";
            response.Data = carts.Select(cart => new CartDto
            {
                Id = cart.Id,
                UserId = cart.UserId,
                CartProducts = cart.CartProducts.Select(cp => new CartProductDto
                {
                    ProductId = cp.ProductId,
                    Quantity = cp.Quantity
                }).ToList(),
                TotalPrice = cart.CartProducts.Sum(cp => cp.Quantity * cp.Product.Price)
            });
            return response;
        }
    }
}
