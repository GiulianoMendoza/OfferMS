using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.DTO.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<OBJETO_QUE_SALE, OBJETO_QUE_ENTRA>().ReverseMap();

            CreateMap<ApplicationCandidateResponse, Aplication>()
                .ReverseMap()
                .ForMember(dest => dest.OfferTitle, opt => opt.MapFrom(src => src.Offer.Title))
                .ForMember(dest => dest.OfferId, opt => opt.MapFrom(src => src.Offer.OfferId))
                .ForMember(dest => dest.ApplicationStatusType, opt => opt.MapFrom(src => src.ApplicationStatusType.Name));
            CreateMap<ApplicationCompanyResponse, Aplication>()
                .ReverseMap()
                .ForMember(dest => dest.OfferTitle, opt => opt.MapFrom(src => src.Offer.Title))
                .ForMember(dest => dest.ApplicationStatusType, opt => opt.MapFrom(src => src.ApplicationStatusType.Name));
            CreateMap<Aplication, ApplicationUpdateRequest>()
                .ReverseMap()
                .ForMember(dest => dest.ApplicationStatusTypeId, opt => opt.MapFrom(src => src.ApplicationStatusTypeId));

            CreateMap<Aplication, ApplicationRequest>()
                .ReverseMap();

            CreateMap<CategoryResponse, Category>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CategoryId));
            CreateMap<CategoryResponse, OfferCategory>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<JobOfferModeResponse, JobOfferMode>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.JobOfferModeId));

            CreateMap<OfferResponse, Offer>()
                .ReverseMap()
                .ForMember(dest => dest.OfferId, opt => opt.MapFrom(src => src.OfferId))
                //.ForMember(dest => dest.CompanyId, opt => opt.MapFrom(src => src.CompanyId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Vacancies, opt => opt.MapFrom(src => src.Vacancies));
            CreateMap<Offer, OfferRequest>().ReverseMap();
            CreateMap<OfferMinimalResponse, Offer>()
                .ReverseMap();
            CreateMap<Offer, OfferRequest>().ReverseMap();


            CreateMap<SkillResponse, Skill>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.SkillId));
            CreateMap<SkillResponse, OfferSkill>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.SkillId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Skill.Name));

            CreateMap<StudyTypeResponse, StudyType>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.StudyTypeId));

            CreateMap<Province, ProvincesResponse>().ReverseMap();
            CreateMap<City, CityResponse>().ReverseMap();

            CreateMap<HTTPError, HTTPResponse<string>>().ReverseMap();
        }
    }
}
