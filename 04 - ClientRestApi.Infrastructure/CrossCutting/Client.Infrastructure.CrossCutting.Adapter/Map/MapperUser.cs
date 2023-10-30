using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;
using Client.Domain.Models;
using Client.Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Client.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperUser : IMapperUser
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
                Address = new Address()
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
                    Address = new AddressDTO()
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
                Address = new AddressDTO()
            };

            return userDTO;
        }
    }
}