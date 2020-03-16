namespace GG.Service.Libraries
{
    using GG.Core.Entities.Libraries;

    /// <summary>
    /// Library service interface
    /// </summary>
    public partial interface ILibraryService
    {
        #region Methods
        /// <summary>
        /// Gets an library by identifier
        /// </summary>
        /// <param name="id">Library identifier</param>
        /// <returns>Library</returns>
        Library GetLibraryById(int id);

        /// <summary>
        /// Insters an library
        /// </summary>
        /// <param name="library">Library</param>
        void InsertLibrary(Library library);

        /// <summary>
        /// Updates an library
        /// </summary>
        /// <param name="library">Library</param>
        void UpdateLibrary(Library library);

        /// <summary>
        /// Deletes an library
        /// </summary>
        /// <param name="library">Library</param>
        void DeleteLibrary(Library library);

        #endregion
    }
}
