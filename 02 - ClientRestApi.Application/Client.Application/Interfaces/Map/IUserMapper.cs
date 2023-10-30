using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;
using Client.Domain.Models;

namespace Client.Application.Interfaces.Map
{
    public interface IUserMapper
    {
        User MapperToEntity(UserDTO userDTO);
        IEnumerable<UserDTO> MapperListUsers(IEnumerable<User> users);
        UserDTO MapperToDto(User user);
        Address MapperAddressToEntity(AddressDTO adress);
        AddressDTO MapperAddressToDto(Address address);
    }
}