using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;

namespace Client.Application.Interfaces
{
    public interface IApplicationServiceUser
    {
        Task Add(UserDTO obj);

        Task<UserDTO> GetById(string id);

        Task<IEnumerable<UserDTO>> GetAll();

        Task Update(UserDTO obj);

        Task Deactivate(string id);
    }
}