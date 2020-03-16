namespace GG.Service.Borroweds
{
    using GG.Core.Entities.Borroweds;
    /// <summary>
    /// Borrowed service interface
    /// </summary>
    public partial interface IBorrowedService
    {
        #region Methods
        /// <summary>
        /// Gets an borrowed by identifier
        /// </summary>
        /// <param name="id">Borrowed identifier</param>
        /// <returns>Borrowed</returns>
        Borrowed GetBorrowedById(int id);

        /// <summary>
        /// Insters an borrowed
        /// </summary>
        /// <param name="borrowed">Borrowed</param>
        void InsertBorrowed(Borrowed borrowed);

        /// <summary>
        /// Updates an borrowed
        /// </summary>
        /// <param name="borrowed">Borrowed</param>
        void UpdateBorrowed(Borrowed borrowed);

        /// <summary>
        /// Deletes an borrowed
        /// </summary>
        /// <param name="borrowed">Borrowed</param>
        void DeleteBorrowed(Borrowed borrowed);

        #endregion
    }
}
