using System;
using AutoMapper;
using Sum.API.Domain.Models;
using Sum.API.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sum.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
