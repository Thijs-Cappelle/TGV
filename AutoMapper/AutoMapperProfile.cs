using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGV.Domain.Entities;
using TGV.ViewModels;

namespace TGV.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Steden, StadVM>();
            CreateMap<AspNetUsers, UserVM>();
            CreateMap<Ritten, RitVM>().ForMember(dest => dest.Start,
                opts => opts.MapFrom(
                    src => src.Lijn.StartStad.Naam))
                .ForMember(dest => dest.Bestemming,
                opts => opts.MapFrom(
                    src => src.Lijn.EindStad.Naam))
            .ForMember(dest => dest.BasisPrijs,
                opts => opts.MapFrom(
                    src => src.Lijn.BasisPrijs));
        }
    }
}
