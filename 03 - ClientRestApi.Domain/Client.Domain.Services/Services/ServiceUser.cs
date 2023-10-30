using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Domain.Core.Interfaces.Repositories;
using Client.Domain.Core.Interfaces.Services;
using Client.Domain.Models;

namespace Client.Domain.Services.Services
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        private readonly IRepositoryUser _repositoryUser;
        public ServiceUser(IRepositoryUser RepositoryUser) 
            : base(RepositoryUser)
        {
            _repositoryUser = RepositoryUser;
        }

        public async Task<bool> VerifyUserExists(string cpf)
        {
           return await _repositoryUser.VerifyUserExists(cpf);
        }
    }
}