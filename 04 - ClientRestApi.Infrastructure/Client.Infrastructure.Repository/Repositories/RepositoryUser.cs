using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Domain.Core.Interfaces.Repositories;
using Client.Domain.Models;
using Client.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Client.Infrastructure.Repository.Repositories
{
    public class RepositoryUser : Repository<User>, IRepositoryUser
    {
        private readonly SqlDatabaseContext _context;
        public RepositoryUser(SqlDatabaseContext Context) 
            : base(Context)
        {
            _context = Context;
        }

        public async Task<User> GetByDocument(string document)
        {
            try
            {
                var user = await _context.Users
                    .Where(us => (us.CPF == document || us.RG == document) && us.IsActive)
                    .FirstOrDefaultAsync();
                
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}