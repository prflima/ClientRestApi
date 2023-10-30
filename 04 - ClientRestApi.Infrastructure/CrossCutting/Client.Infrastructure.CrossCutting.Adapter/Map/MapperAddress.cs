using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;
using Client.Domain.Models;
using Client.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Client.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperAddress : IMapperAddress
    {
        public Address MapperToEntity(AddressDTO addressDTO)
        {
            Address address = new Address
            {
                Id = Guid.Parse(addressDTO.Id),
                City = addressDTO.City,
                Complement = addressDTO.Complement,
                Number = addressDTO.Number,
                Neighborhood = addressDTO.Neighborhood,
                Street = addressDTO.Street,
                StreetCode = addressDTO.StreetCode,
                IsActive = addressDTO.IsActive
            };

            return address;
        }

        public AddressDTO MapperToDto(Address address)
        {
            AddressDTO addressDTO = new AddressDTO
            {
                Id = address.Id.ToString(),
                City = address.City,
                Complement = address.Complement,
                Number = address.Number,
                Neighborhood = address.Neighborhood,
                Street = address.Street,
                StreetCode = address.StreetCode,
                IsActive = address.IsActive
            };

            return addressDTO;
        }
    }
}