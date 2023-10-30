using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Application.DTOs
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public AddressDTO Address { get; set; }
        public bool IsActive { get; set; }
    }
}