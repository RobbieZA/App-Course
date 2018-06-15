using System.Linq;
using AutoMapper;
using RPAPI.Dtos;
using RPAPI.Models;

namespace RPAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
        CreateMap<User,UserForListDto>()
        .ForMember(dest => dest.PhotoUrl, opt => {
            opt.MapFrom(src =>src.Photos.FirstOrDefault(p=>p.IsMain).Url);
        })
        .ForMember(dest => dest.Age, opt => {
            opt.ResolveUsing(d=>d.DateOfBirth.CalcAge());
        });
        
        CreateMap<User, UserForDetailDto>()
        .ForMember(dest => dest.PhotoUrl, opt => {
            opt.MapFrom(src =>src.Photos.FirstOrDefault(p=>p.IsMain).Url);
        })
        .ForMember(dest => dest.Age, opt => {
            opt.ResolveUsing(d=>d.DateOfBirth.CalcAge());
        });
        CreateMap<photo, PhotosForDetailDto>();
        }
    }
}