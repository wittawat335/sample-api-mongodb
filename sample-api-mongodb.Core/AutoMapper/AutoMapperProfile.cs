﻿using AutoMapper;
using sample_api_mongodb.Core.DTOs;
using sample_api_mongodb.Core.Entities;

namespace sample_api_mongodb.Core.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductDTO, Products>();
            
            CreateMap<Products, ProductDTO>()
                .ForMember(x => x.Active, 
                opt => opt.MapFrom(o => o.Active == true ? "1" : "0"));




            CreateMap<UserDTO, Users>();




            CreateMap<Users, UserDTO>()
                    .ForMember(x => x.active, 
                    opt => opt.MapFrom(o => o.Active == true ? "1" : "0"));

            CreateMap<ApplicationUser, UserDTO>()
              .ForMember(x => x.active, 
              opt => opt.MapFrom(o => o.Active == true ? "1" : "0"));

            CreateMap<ApplicationUser, Users>()
                .ForMember(x => x.Id,
                opt => opt.MapFrom(origin => origin.Id.ToString()));







            CreateMap<UserDTO, ApplicationUser>()
               .ForMember(x => x.Roles, opt => opt.Ignore());
        }
    }
}
