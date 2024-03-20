using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    public bool AddProduct(Product product)
    {
        InMemoryDataSource.Products.Add(product);
        return true;
    }

    public List<Product> GetProducts() => InMemoryDataSource.Products;
}