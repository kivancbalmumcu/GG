namespace GG.Service.Users
{
    using GG.Core.Entities.Users;

    /// <summary>
    /// ApplicationUser service interface
    /// </summary>
    public partial interface IApplicationUserService
    {
        #region Methods

        /// <summary>
        /// Gets an applicationUser by identifier
        /// </summary>
        /// <param name="id">ApplicationUser identifier</param>
        /// <returns>ApplicationUser</returns>
        ApplicationUser GetApplicationUserById(int id);

        /// <summary>
        /// Insters an applicationUser
        /// </summary>
        /// <param name="applicationUser">ApplicationUser</param>
        void InsertApplicationUser(ApplicationUser applicationUser);

        /// <summary>
        /// Updates an applicationUser
        /// </summary>
        /// <param name="applicationUser">ApplicationUser</param>
        void UpdateApplicationUser(ApplicationUser applicationUser);

        /// <summary>
        /// Deletes an applicationUser
        /// </summary>
        /// <param name="applicationUser">ApplicationUser</param>
        void DeleteApplicationUser(ApplicationUser applicationUser);

        /// <summary>
        /// Get applicationUser by email
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns>ApplicationUser</returns>
        ApplicationUser GetApplicationUserByEmail(string email);

        #endregion
    }
}
