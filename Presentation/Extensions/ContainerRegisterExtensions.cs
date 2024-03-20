using Application.Services;
using Application.Utilities;
using AutoMapper;
using Domain.Repositories;
using Infrastructure.Repositories;

namespace Presentation.Extensions;

public static class ContainerRegisterExtensions
{
    public static void AddCorePackages(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductRepository, ProductRepository>();
        var config = new MapperConfiguration(c =>
        {
            c.AddProfile<GeneralMapping>();
        });
        services.AddScoped(s => config.CreateMapper());

    }
}