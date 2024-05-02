using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Dress;
using dotnet_rpg.Entities;

namespace dotnet_rpg.Services.DressService
{
    public interface IDressService
    {
        Task<ServiceResponse<List<GetDressDto>>> GetAllDresses();
        Task<ServiceResponse<GetDressDto>> GetDressById(int id);
        Task<ServiceResponse<List<GetDressDto>>> AddDress(AddDressDto newDress);
        Task<ServiceResponse<GetDressDto>> UpdateDress(UpdateDressDto updatedDress);
        Task<ServiceResponse<List<GetDressDto>>> DeleteDress(int id);

    }
}