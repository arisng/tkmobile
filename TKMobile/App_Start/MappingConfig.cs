using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TKMobile.Core.Entities.User;
using TKMobile.Models;

namespace TKMobile
{
    public static class MappingConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(config =>
                {
                    config.CreateMap<ApplicationUser, UserDetailsViewModel>()
                        .ForMember(dest => dest.FullName,
                                opt => opt.MapFrom(src => String.Format("{0} {1}", src.LastName, src.FirstName)))
                        .ForMember(dest => dest.BirthDateString,
                                opt => opt.MapFrom(src => src.BirthDate.ToShortDateString()));

                });
        }
    }
}