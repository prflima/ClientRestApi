using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;

namespace Client.Application.Interfaces
{
    public interface IApplicationServiceUser
    {
        Task<bool> Add(UserDTO obj);

        Task<UserDTO> GetById(string id);

        Task<IEnumerable<UserDTO>> GetAll();

        Task<bool> Update(UserDTO obj);

        Task<bool> Deactivate(string id);
    }
}