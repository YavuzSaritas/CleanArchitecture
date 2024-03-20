using Application.Models;

namespace Application.Services;

public interface IProductService
{
    bool AddProduct(ProductModel productDto);
    List<ProductModel> GetProducts();
}