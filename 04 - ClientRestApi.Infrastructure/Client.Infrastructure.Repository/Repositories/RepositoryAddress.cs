using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Domain.Core.Interfaces.Repositories;
using Client.Domain.Models;
using Client.Infrastructure.Data;

namespace Client.Infrastructure.Repository.Repositories
{
    public class RepositoryAddress : Repository<Address>, IRepositoryAddress
    {
        private readonly SqlDatabaseContext _context;
        public RepositoryAddress(SqlDatabaseContext Context) 
            : base(Context)
        {
            _context = Context;
        }
    }
}