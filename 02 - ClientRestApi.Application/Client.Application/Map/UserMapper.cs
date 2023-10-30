using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;
using Client.Application.Interfaces.Map;
using Client.Domain.Models;

namespace Client.Application.Map
{
    public class UserMapper : IUserMapper
    {
        List<UserDTO> userDTOs = new List<UserDTO>();

        public User MapperToEntity(UserDTO userDTO)
        {
            User user = new User
            {
                Id = Guid.Parse(userDTO.Id),
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                CPF = userDTO.CPF,
                RG = userDTO.RG,
                IsActive = userDTO.IsActive,
                Address = MapperAddressToEntity(userDTO.Address)
            };

            return user;
        }
        public IEnumerable<UserDTO> MapperListUsers(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                UserDTO userDTO = new UserDTO
                {
                    Id = user.Id.ToString(),
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    CPF = user.CPF,
                    RG = user.RG,
                    IsActive = user.IsActive,
                    Address = MapperAddressToDto(user.Address)
                };

                userDTOs.Add(userDTO);
            }

            return userDTOs;
        }

        public UserDTO MapperToDto(User user)
        {
            UserDTO userDTO = new UserDTO
            {
                Id = user.Id.ToString(),
                FirstName = user.FirstName,
                LastName = user.LastName,
                CPF = user.CPF,
                RG = user.RG,
                IsActive = user.IsActive,
                Address = MapperAddressToDto(user.Address)
            };

            return userDTO;
        }

        public Address MapperAddressToEntity(AddressDTO addressDTO)
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

        public AddressDTO MapperAddressToDto(Address address)
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