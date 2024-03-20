using Domain.Entities;

namespace Domain.Repositories;

public interface IProductRepository
{
    public bool AddProduct(Product product);
    public List<Product> GetProducts();
}