using Application.DTOs;
using Application.Interface.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCart([FromBody] CartRequest cart)
        {
            var response = await _cartService.CreateCart(cart);
            return response.Success ? Ok(response) : BadRequest(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCart(Guid id, [FromBody] CartUpdateRequest cart)
        {
            var response = await _cartService.UpdateCart(id, cart);
            return response.Success ? Ok(response) : BadRequest(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCart(Guid id)
        {
            var response = await _cartService.GetCart(id);
            return response.Success ? Ok(response) : BadRequest(response);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetCartsByUserId(Guid userId)
        {
            var response = await _cartService.GetCartsByUserId(userId);
            return response.Success ? Ok(response) : BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetCarts()
        {
            var response = await _cartService.GetCarts();
            return response.Success ? Ok(response) : BadRequest(response);
        }
    }
}
