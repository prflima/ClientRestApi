using System;

namespace Client.Domain.Models
{
    /// <summary>
    /// Base class to all entities.
    /// </summary>
    public abstract class Base
    {
        /// <summary>
        /// Entity identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Indicates if entity is active or not.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Registration date.
        /// </summary>
        public DateTime CreationDate { get; set; }
    }
}