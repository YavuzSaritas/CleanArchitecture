using Application.Models;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public bool AddProduct(ProductModel productDto) =>  _productRepository.AddProduct(_mapper.Map<Product>(productDto));

    public List<ProductModel> GetProducts() => _mapper.Map<List<ProductModel>>( _productRepository.GetProducts());
    
}