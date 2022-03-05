using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO = ECommerceSystem.Training.Entities;
using BO = ECommerceSystem.Training.BusinessObjects;

namespace ECommerceSystem.Training.Profiles
{
   public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<EO.Customer, BO.Customer>().ReverseMap();
            CreateMap<EO.Category, BO.Category>().ReverseMap();
            CreateMap<EO.Product, BO.Product>().ReverseMap();
        }
    }
}
