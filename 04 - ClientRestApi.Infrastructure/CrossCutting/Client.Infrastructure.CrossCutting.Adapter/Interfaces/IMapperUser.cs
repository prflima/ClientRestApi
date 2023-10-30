using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;
using Client.Domain.Models;

namespace Client.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperUser
    {
        User MapperToEntity(UserDTO userDTO);
        IEnumerable<UserDTO> MapperListUsers(IEnumerable<User> users);
        UserDTO MapperToDto(User user);
    }
}