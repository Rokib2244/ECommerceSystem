using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceSystem.Models;
using ECommerceSystem.Training.BusinessObjects;

namespace ECommerceSystem.Profiles
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            CreateMap<CreateProductModel, Product>().ReverseMap();
            CreateMap<EditProductModel, Product>().ReverseMap();
        }
    }
}
