namespace GG.Service.Authors
{
    using GG.Core.Entities.Authors;
    
    /// <summary>
    /// Author service interface
    /// </summary>
    public partial interface IAuthorService
    {
        #region Methods
        /// <summary>
        /// Gets an author by identifier
        /// </summary>
        /// <param name="id">Author identifier</param>
        /// <returns>Author</returns>
        Author GetAuthorById(int id);

        /// <summary>
        /// Insters an author
        /// </summary>
        /// <param name="author">Author</param>
        void InsertAuthor(Author author);

        /// <summary>
        /// Updates an author
        /// </summary>
        /// <param name="author">Author</param>
        void UpdateAuthor(Author author);

        /// <summary>
        /// Deletes an author
        /// </summary>
        /// <param name="author">Author</param>
        void DeleteAuthor(Author author);

        #endregion
    }
}
