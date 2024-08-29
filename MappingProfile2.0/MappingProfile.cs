using AutoMapper;
using Markiian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markiian
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {
            CreateMap<Empoyee, EmployeeDTO>()
            .ForMember(dest => dest.IdPerosne, opt => opt.Ignore()) 
            .ForMember(dest => dest.Company, opt => opt.Ignore())
            .ForMember(dest => dest.BirthDay, opt => opt.MapFrom(src => DateTime.Now.AddYears(-src.Age)))
            .ForMember(dest => dest.Spetialization, opt => opt.MapFrom(src => src.Position))
            .ForMember(dest => dest.AverageSelery, opt => opt.MapFrom(src => src.Selery));
        }
    }
}
