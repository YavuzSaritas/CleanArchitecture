using Application.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.Utilities;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<ProductModel, Product>().ReverseMap();
    }
}