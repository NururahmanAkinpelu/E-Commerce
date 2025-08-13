using Application.DTOs;
using Application.Interface.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddProduct([FromBody] ProductRequest product)
        {
            var response = await _productService.AddProduct(product);
            return response.Success ? Ok(response) : BadRequest(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            var response = await _productService.GetProduct(id);
            return response.Success ? Ok(response) : BadRequest(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var response = await _productService.GetProducts();
            return response.Success ? Ok(response) : BadRequest(response);
        }
    }
}
