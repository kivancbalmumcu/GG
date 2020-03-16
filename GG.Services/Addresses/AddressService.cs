namespace GG.Service.Addresses
{
    using GG.Core.Entities.Addresses;
    using GG.Data.EfRepository;
    using System;

    /// <summary>
    /// Address service
    /// </summary>
    public partial class AddressService : IAddressService
    {
        #region Fields

        private readonly IRepository<Address> _addressRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public AddressService()
        {
            this._addressRepository = new Repository<Address>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an address by address identifier
        /// </summary>
        /// <param name="id">Address identifier</param>
        /// <returns>Address</returns>
        public virtual Address GetAddressById(int id)
        {

            if (id == 0)
                throw (new ArgumentNullException("parameter missing"));

            var address = _addressRepository.GetById(id);

            return address;
        }

        /// <summary>
        /// Inserts an address
        /// </summary>
        /// <param name="address">Address</param>
        public virtual void InsertAddress(Address address)
        {
            if (address == null)
                throw (new ArgumentNullException("parameter missing"));

            _addressRepository.Insert(address);
        }

        /// <summary>
        /// Updates an address
        /// </summary>
        /// <param name="address">Address</param>
        public virtual void UpdateAddress(Address address)
        {
            if (address == null)
                throw (new ArgumentNullException("parameter missing"));

            _addressRepository.Update(address);
        }

        /// <summary>
        /// Deletes an address
        /// </summary>
        /// <param name="address">Address</param>
        public virtual void DeleteAddress(Address address)
        {
            if (address == null)
                throw (new ArgumentNullException("parameter missing"));

            _addressRepository.Delete(address);
        }

        #endregion
    }
}

