using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Entities;

namespace dotnet_rpg.Services.DressService
{
    public interface IDressService
    {
        Task<ServiceResponse<List<Dress>>> GetAllDresses();
        Task<ServiceResponse<Dress>> GetDressById(int id);
        Task<ServiceResponse<List<Dress>>> AddDress(Dress newDress);
    }
}