using AutoMapper;
using cms.Application.ViewModels.Product;
using cms.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoryViewModel, Category>()
                .ConstructUsing(c => new Category(c.Name, c.Description, c.ParentId, c.FriendlyURL, c.Status, c.MetaKeyword, 
                                c.MetaDescription, c.SortOrder, c.DateCreated, c.OwnerId, c.DateModified, c.ModifiedOwnerId));
        }
    }
}
