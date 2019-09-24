using AutoMapper;
using Sum.API.Domain.Models;
using Sum.API.Resources;

namespace Sum.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}
