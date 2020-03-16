namespace GG.Service.Users
{
    using GG.Core.Entities.Users;
    using GG.Data.EfRepository;
    using System;
    using System.Linq;

    /// <summary>
    /// ApplicationUser service 
    /// </summary>
    public partial class ApplicationUserService : IApplicationUserService
    {
        #region Fields

        private readonly IRepository<ApplicationUser> _applicationUserRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ApplicationUserService()
        {
            this._applicationUserRepository = new Repository<ApplicationUser>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an address by ApplicationUser identifier
        /// </summary>
        /// <param name="id">ApplicationUser identifier</param>
        /// <returns>ApplicationUser</returns>
        public virtual ApplicationUser GetApplicationUserById(int id)
        {

            if (id == 0)
                throw (new ArgumentNullException("parameter missing"));

            var applicationUser = _applicationUserRepository.GetById(id);

            return applicationUser;
        }

        /// <summary>
        /// Inserts an applicationUser
        /// </summary>
        /// <param name="applicationUser">ApplicationUser</param>
        public virtual void InsertApplicationUser(ApplicationUser applicationUser)
        {
            if (applicationUser == null)
                throw (new ArgumentNullException("parameter missing"));

            _applicationUserRepository.Insert(applicationUser);
        }

        /// <summary>
        /// Updates an applicationUser
        /// </summary>
        /// <param name="applicationUser">ApplicationUser</param>
        public virtual void UpdateApplicationUser(ApplicationUser applicationUser)
        {
            if (applicationUser == null)
                throw (new ArgumentNullException("parameter missing"));

            _applicationUserRepository.Update(applicationUser);
        }

        /// <summary>
        /// Deletes an applicationUser
        /// </summary>
        /// <param name="applicationUser">ApplicationUser</param>
        public virtual void DeleteApplicationUser(ApplicationUser applicationUser)
        {
            if (applicationUser == null)
                throw (new ArgumentNullException("parameter missing"));

            _applicationUserRepository.Delete(applicationUser);
        }

        /// <summary>
        /// Get applicationUser by email
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns>ApplicationUser</returns>
        public virtual ApplicationUser GetApplicationUserByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return null;

            var query = from c in _applicationUserRepository.Table
                        orderby c.Id
                        where c.Email == email
                        select c;
            var applicationUser = query.FirstOrDefault();
            return applicationUser;
        }

        #endregion
    }
}

