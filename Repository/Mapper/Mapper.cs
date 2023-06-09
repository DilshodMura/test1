using AutoMapper;
using database.Entities;
using Domain.Models;
using Repository.Business_Models;

namespace Repository.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, IUser>().ReverseMap();
            CreateMap<UserBusiness, IUser>().ReverseMap();

            CreateMap<FileEntity, IFileEntity>().ReverseMap();
            CreateMap<FileEntityBusiness, IFileEntity>().ReverseMap();

            CreateMap<Company, ICompany>().ReverseMap();
            CreateMap<CompanyBusiness, Company>();

            CreateMap<ChatMessage, IChatMessage>().ReverseMap();
            CreateMap<ChatMessageBusiness,ChatMessage>();

            CreateMap<DesignBusiness, Design>();
            CreateMap<Design, IDesign>().ReverseMap();
        }
    }
}
