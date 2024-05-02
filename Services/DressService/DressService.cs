using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Dress;
using dotnet_rpg.Entities;

namespace dotnet_rpg.Services.DressService
{
    public class DressService : IDressService
    {
        private static List<Dress> dresses = new List<Dress> {
            new Dress(),
            new Dress { Id = 1, Name = "dfs" }
        };
        private readonly IMapper _mapper;

        public DressService(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        public async Task<ServiceResponse<List<GetDressDto>>> AddDress(AddDressDto newDress)
        {
            var serviceResponse = new ServiceResponse<List<GetDressDto>>();
            dresses.Add(_mapper.Map<Dress>(newDress));
            serviceResponse.Data = dresses.Select(c => _mapper.Map<GetDressDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetDressDto>>> DeleteDress(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetDressDto>>();

            try {
                var dress = dresses.FirstOrDefault(c => c.Id == id);
                if (dress is null)
                    throw new Exception($"Dress with Id '{id}' not found.");

                dresses.Remove(dress);

                serviceResponse.Data = dresses.Select(c => _mapper.Map<GetDressDto>(c)).ToList();

            } catch (Exception ex) 
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetDressDto>>> GetAllDresses()
        {
            var serviceResponse = new ServiceResponse<List<GetDressDto>>();
            serviceResponse.Data = dresses.Select(c => _mapper.Map<GetDressDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetDressDto>> GetDressById(int id)
        {
            var serviceResponse = new ServiceResponse<GetDressDto>();
            var dress = dresses.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetDressDto>(dress);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetDressDto>> UpdateDress(UpdateDressDto updatedDress)
        {
            var serviceResponse = new ServiceResponse<GetDressDto>();

            try {
                var dress = dresses.FirstOrDefault(c => c.Id == updatedDress.Id);
                if (dress is null)
                    throw new Exception($"Dress with Id '{updatedDress.Id}' not found.");

                dress.Name = updatedDress.Name;
                dress.Color = dress.Color;
                dress.Description = updatedDress.Description;

                serviceResponse.Data = _mapper.Map<GetDressDto>(dress);

            } catch (Exception ex) 
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}