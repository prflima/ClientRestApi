
using System.Collections.Generic;

namespace Client.Domain.Models
{
    /// <summary>
    /// Client entity.
    /// </summary>
    public class User : Base
    {   
        /// <summary>
        /// The first name of client
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of client
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The document RG of client.
        /// </summary>
        public string RG { get; set; }
        
        /// <summary>
        /// The document CPF of client 
        /// </summary>
        public string CPF { get; set; }

        public List<Address> Address { get; set; }
    }
}