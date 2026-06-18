using APIProje.WebApi.Dtos.FeatureDtos;
using APIProje.WebApi.Dtos.MessageDtos;
using APIProje.WebApi.Dtos.ProductDtos;
using APIProje.WebApi.Entities;
using AutoMapper;

namespace APIProje.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategoryDto>().ForMember(x=>x.CateogoryName,y=>y.MapFrom
            (z=>z.Category.CategoryName)).ReverseMap();


        }
    }
}
