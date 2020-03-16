namespace GG.Service.Addresses
{
    using GG.Core.Entities.Addresses;


    /// <summary>
    /// Address service interface
    /// </summary>
    public partial interface IAddressService
    {
        #region Methods

        /// <summary>
        /// Gets an address by identifier
        /// </summary>
        /// <param name="id">Address identifier</param>
        /// <returns>Address</returns>
        Address GetAddressById(int id);

        /// <summary>
        /// Insters an address
        /// </summary>
        /// <param name="address">Address</param>
        void InsertAddress(Address address);

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="address">Address</param>
        void UpdateAddress(Address address);

        /// <summary>
        /// Deletes an address
        /// </summary>
        /// <param name="address">Address</param>
        void DeleteAddress(Address address);
        //Todo: what are Autofac Garbagecollector
        #endregion
    }
}
