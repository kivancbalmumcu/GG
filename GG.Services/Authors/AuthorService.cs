namespace GG.Service.Authors
{
    using GG.Core.Entities.Authors;
    using GG.Data.EfRepository;
    using System;

    /// <summary>
    /// Author service
    /// </summary>
    public partial class AuthorService : IAuthorService
    {
        #region Fields

        private readonly IRepository<Author> _authorRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public AuthorService()
        {
            this._authorRepository = new Repository<Author>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an address by Author identifier
        /// </summary>
        /// <param name="id">Author identifier</param>
        /// <returns>Author</returns>
        public virtual Author GetAuthorById(int id)
        {

            if (id == 0)
                throw (new ArgumentNullException("parameter missing"));

            var author = _authorRepository.GetById(id);

            return author;
        }

        /// <summary>
        /// Inserts an author
        /// </summary>
        /// <param name="author">Author</param>
        public virtual void InsertAuthor(Author author)
        {
            if (author == null)
                throw (new ArgumentNullException("parameter missing"));

            _authorRepository.Insert(author);
        }

        /// <summary>
        /// Updates an author
        /// </summary>
        /// <param name="author">Author</param>
        public virtual void UpdateAuthor(Author author)
        {
            if (author == null)
                throw (new ArgumentNullException("parameter missing"));

            _authorRepository.Update(author);
        }

        /// <summary>
        /// Deletes an author
        /// </summary>
        /// <param name="author">Author</param>
        public virtual void DeleteAuthor(Author author)
        {
            if (author == null)
                throw (new ArgumentNullException("parameter missing"));

            _authorRepository.Delete(author);
        }

        #endregion
    }
}

