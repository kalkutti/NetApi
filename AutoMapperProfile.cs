using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Dress;
using dotnet_rpg.Entities;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Dress, GetDressDto>();
            CreateMap<AddDressDto, Dress>();
        }
    }
}