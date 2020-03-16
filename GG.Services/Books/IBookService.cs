namespace GG.Service.Books
{
    using GG.Core.Entities.Books;

    /// <summary>
    /// Book service interface
    /// </summary>
    public partial interface IBookService
    {
        #region Methods
        /// <summary>
        /// Gets an book by identifier
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <returns>Book</returns>
        Book GetBookById(int id);

        /// <summary>
        /// Insters an book
        /// </summary>
        /// <param name="book">Book</param>
        void InsertBook(Book book);

        /// <summary>
        /// Updates an book
        /// </summary>
        /// <param name="book">Book</param>
        void UpdateBook(Book book);

        /// <summary>
        /// Deletes an book
        /// </summary>
        /// <param name="book">Book</param>
        void DeleteBook(Book book);

        void BookLibraryExists(int bookId, int libraryId);

        #endregion
    }
}
