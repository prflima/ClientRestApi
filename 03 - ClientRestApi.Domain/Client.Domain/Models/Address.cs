namespace Client.Domain.Models
{
    /// <summary>
    /// Address entity.
    /// </summary>
    public class Address : Base
    {
        /// <summary>
        /// The street's name
        /// </summary>
        public string Street { get; set; }
        
        /// <summary>
        /// The code street. (CEP for example)
        /// </summary>
        public int StreetCode { get; set; }

        /// <summary>
        /// The numbers house
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// The district or neighborhood.
        /// </summary>    
        public string Neighborhood { get; set; }

        /// <summary>
        /// The complement house.
        /// </summary>
        public string Complement { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        public string City { get; set; }


        /// <summary>
        /// The state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The user of address.
        /// </summary>
        public User User { get; set; }
    }
}