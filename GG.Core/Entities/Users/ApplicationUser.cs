namespace GG.Core.Entities.Users
{
    using System;

    /// <summary>
    /// Represents an ApplicationUser
    /// </summary>
    public partial class ApplicationUser : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the TurkishIdentityNumber
        /// </summary>
        public string TurkishIdentityNumber { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the Surname
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the DateOfBirth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the IsActive
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the IsDeleted
        /// </summary>
        public bool Deleted { get; set; }

        #endregion
    }
}
