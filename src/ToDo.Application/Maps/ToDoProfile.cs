using AutoMapper;
using ToDo.Application.DTOs;

namespace ToDo.Application.Maps
{
    public class ToDoProfile : Profile
    {
        public ToDoProfile()
        {
            CreateMap<ToDoDto, Models.ToDo>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.CompletedAt, opt => opt.MapFrom(src => src.CompletedAt))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId));

            CreateMap<Models.ToDo, ToDoDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.CompletedAt, opt => opt.MapFrom(src => src.CompletedAt))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId));
        }
    }
}
