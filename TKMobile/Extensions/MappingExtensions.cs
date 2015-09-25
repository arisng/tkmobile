using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TKMobile.Core.Entities.User;
using TKMobile.Models;

namespace TKMobile.Extensions
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }

        public static UserDetailsViewModel ToViewModel(this ApplicationUser model)
        {
            return model.MapTo<ApplicationUser, UserDetailsViewModel>();
        }
    }
}