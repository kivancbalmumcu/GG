namespace GG.Service.Borroweds
{
    using GG.Core.Entities.Borroweds;
    using GG.Data.EfRepository;
    using System;

    /// <summary>
    /// Borrowed service
    /// </summary>
    public partial class BorrowedService : IBorrowedService
    {
        #region Fields

        private readonly IRepository<Borrowed> _borrowedRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public BorrowedService()
        {
            this._borrowedRepository = new Repository<Borrowed>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an address by Borrowed identifier
        /// </summary>
        /// <param name="id">Borrowed identifier</param>
        /// <returns>Borrowed</returns>
        public virtual Borrowed GetBorrowedById(int id)
        {

            if (id == 0)
                throw (new ArgumentNullException("parameter missing"));

            var borrowed = _borrowedRepository.GetById(id);

            return borrowed;
        }

        /// <summary>
        /// Inserts an borrowed
        /// </summary>
        /// <param name="borrowed">Borrowed</param>
        public virtual void InsertBorrowed(Borrowed borrowed)
        {
            if (borrowed == null)
                throw (new ArgumentNullException("parameter missing"));

            _borrowedRepository.Insert(borrowed);
        }

        /// <summary>
        /// Updates an borrowed
        /// </summary>
        /// <param name="borrowed">Borrowed</param>
        public virtual void UpdateBorrowed(Borrowed borrowed)
        {
            if (borrowed == null)
                throw (new ArgumentNullException("parameter missing"));

            _borrowedRepository.Update(borrowed);
        }

        /// <summary>
        /// Deletes an borrowed
        /// </summary>
        /// <param name="borrowed">Borrowed</param>
        public virtual void DeleteBorrowed(Borrowed borrowed)
        {
            if (borrowed == null)
                throw (new ArgumentNullException("parameter missing"));

            _borrowedRepository.Delete(borrowed);
        }

        #endregion
    }
}

