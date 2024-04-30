using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Entities;

namespace dotnet_rpg.Services.DressService
{
    public class DressService : IDressService
    {
        private static List<Dress> dresses = new List<Dress> {
            new Dress(),
            new Dress { Id = 1, Name = "dfs" }
        };
        
        public async Task<ServiceResponse<List<Dress>>> AddDress(Dress newDress)
        {
            var serviceResponse = new ServiceResponse<List<Dress>>();
            dresses.Add(newDress);
            serviceResponse.Data = dresses;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Dress>>> GetAllDresses()
        {
            var serviceResponse = new ServiceResponse<List<Dress>>();
            serviceResponse.Data = dresses;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Dress>> GetDressById(int id)
        {
            var serviceResponse = new ServiceResponse<Dress>();
            var dress = dresses.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = dress;
            return serviceResponse;
        }
    }
}