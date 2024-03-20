using Domain.Entities;

namespace Infrastructure.Contexts;

public static class InMemoryDataSource
{
    public static List<Product> Products { get; set; } = new();
}