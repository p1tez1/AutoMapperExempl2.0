using AutoMapper;
using System.Runtime.InteropServices;

namespace Markiian
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.Name} {src.LastName}"))
                .ForMember(dest => dest.NicName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.BirthDay, opt => opt.MapFrom(src => DateTime.Now.Year - src.Age))
                .ForMember(dest => dest.Spetialization, opt => opt.MapFrom(src => src.Position))
                .ForMember(dest => dest.BestSelery, opt => opt.MapFrom(src => src.Selery));
        }
        
    }
}
