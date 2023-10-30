using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Client.Application.Interfaces;
using Client.Application.Interfaces.Map;
using Client.Application.Map;
using Client.Application.Services;
using Client.Domain.Core.Interfaces.Repositories;
using Client.Domain.Core.Interfaces.Services;
using Client.Domain.Services.Services;
using Client.Infrastructure.Repository.Repositories;

namespace Client.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceUser>().As<IApplicationServiceUser>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceUser>().As<IServiceUser>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryUser>().As<IRepositoryUser>();
            builder.RegisterType<RepositoryAddress>().As<IRepositoryAddress>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<UserMapper>().As<IUserMapper>();
            builder.RegisterType<AddressMapper>().As<IAddressMapper>();
            #endregion

            #endregion

        }
    }
}