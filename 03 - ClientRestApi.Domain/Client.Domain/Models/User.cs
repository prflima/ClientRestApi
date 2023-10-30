
using System.Collections.Generic;

namespace Client.Domain.Models
{
    /// <summary>
    /// User entity.
    /// </summary>
    public class User : Base
    {   
        /// <summary>
        /// The first name of user.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of user.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The document RG of user.
        /// </summary>
        public string RG { get; set; }
        
        /// <summary>
        /// The document CPF of user. 
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// The Address of user.
        /// </summary>
        public Address Address { get; set; }
    }
}