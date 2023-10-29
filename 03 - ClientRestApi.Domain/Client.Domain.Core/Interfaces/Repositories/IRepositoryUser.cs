using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Domain.Models;

namespace Client.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryUser : IRepository<User>
    {
        Task<bool> VerifyUserExists(string cpf);
    }
}