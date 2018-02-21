using AutoMapper;
using cms.Application.ViewModels.Product;
using cms.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
