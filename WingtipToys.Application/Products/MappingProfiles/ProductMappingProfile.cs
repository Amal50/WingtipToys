using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WingtipToys.Application.Products.Commands;
using WingtipToys.Application.Products.Dtos;
using WingtipToys.Domain.Entities;

namespace WingtipToys.Application.Products.MappingProfiles
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
        }
    }
}
