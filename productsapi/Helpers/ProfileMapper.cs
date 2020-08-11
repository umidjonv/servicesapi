using AutoMapper;
using productsapi.DTO;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace productsapi.Helpers
{
    public class ProfileMapper:Profile
    {
        public ProfileMapper()
        {
            CreateMap<Category, CategoryReadDTO>()
                .ForMember(d => d.parent_name, opt => opt.MapFrom(src => src.parent.name));

            CreateMap<CategoryWriteDTO, Category>();
            //.ForMember(x => x.parent, w => w.MapFrom(src => src.parent_id));

            CreateMap<Product, ProductReadDTO>()
                .ForMember(d => d.category_name, opt => opt.MapFrom(src => src.category.name));

            CreateMap<ProductWriteDTO, Product>()
                .ForMember(d => d.category, opt => opt.MapFrom(src => src.category));

        }
    }
}
