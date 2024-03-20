using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController:ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("get-products")]
    public ActionResult GetProducts() => Ok( _productService.GetProducts());
    
    [HttpPost]
    public ActionResult AddProduct([FromBody] ProductModel productDto) => Ok(_productService.AddProduct(productDto));
}