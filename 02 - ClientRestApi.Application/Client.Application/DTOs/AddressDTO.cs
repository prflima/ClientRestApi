using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Application.DTOs
{
    public class AddressDTO
    {
        public string Id { get; set; }
        public string Street { get; set; }
        public int StreetCode { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool IsActive { get; set; }
    }
}