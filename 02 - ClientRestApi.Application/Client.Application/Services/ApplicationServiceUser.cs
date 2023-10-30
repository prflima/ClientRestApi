using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;
using Client.Application.Interfaces;
using Client.Domain.Core.Interfaces.Services;
using Client.Domain.Models;

namespace Client.Application.Services
{
    public class ApplicationServiceUser : IApplicationServiceUser
    {
        private readonly IServiceUser _serviceUser;
        // private readonly IMapperUser _mapperUser;

        public ApplicationServiceUser(IServiceUser ServiceUser)
        {
            _serviceUser = ServiceUser;
        }

        public async Task<bool> Add(UserDTO obj)
        {
            // var entity = _mapperUser.MapperToEntity(obj);
            return await _serviceUser.Add(new User());
        }

        public async Task<bool> Deactivate(string id)
        {
            return await _serviceUser.Deactivate(Guid.Parse(id));
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            var users = await _serviceUser.GetAll();
            // return _mapper.MapperListUsers();
            return null;
        }

        public async Task<UserDTO> GetById(string id)
        {
            var user = await _serviceUser.GetById(Guid.Parse(id));
            // return _mapper.MapperListUsers();
            return null;
        }

        public async Task<bool> Update(UserDTO obj)
        {
            // var entity = _mapperUser.MapperToEntity(obj);
            return await _serviceUser.Update(new User());
        }
    }
}