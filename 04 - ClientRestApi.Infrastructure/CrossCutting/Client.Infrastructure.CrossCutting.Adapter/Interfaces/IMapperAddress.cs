using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Application.DTOs;
using Client.Domain.Models;

namespace Client.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperAddress
    {
        Address MapperToEntity(AddressDTO adress);
        AddressDTO MapperToDto(Address address);
    }
}