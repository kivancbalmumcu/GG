namespace GG.Service.Books
{
    using GG.Core.Entities.Books;
    using GG.Core.Entities.Libraries;
    using GG.Data.EfRepository;
    using System;
    using System.Linq;

    /// <summary>
    /// Book service
    /// </summary>
    public partial class BookService : IBookService
    {
        #region Fields

        private readonly IRepository<Book> _bookRepository;
        private readonly IRepository<Library> _libraryRepository;
        private readonly IRepository<LibraryBookMapping> _libraryBookMappingRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public BookService()
        {
            this._bookRepository = new Repository<Book>();
            this._libraryBookMappingRepository = new Repository<LibraryBookMapping>();
            this._libraryRepository = new Repository<Library>();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Gets an address by Book identifier
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <returns>Book</returns>
        public virtual Book GetBookById(int id)
        {

            if (id == 0)
                throw (new ArgumentNullException("parameter missing"));

            var book = _bookRepository.GetById(id);

            return book;
        }
        /// <summary>
        /// Inserts an book
        /// </summary>
        /// <param name="book">Book</param>
        public virtual void InsertBook(Book book)
        {
            if (book == null)
                throw (new ArgumentNullException("parameter missing"));

            _bookRepository.Insert(book);
        }
        /// <summary>
        /// Updates an book
        /// </summary>
        /// <param name="book">Book</param>
        public virtual void UpdateBook(Book book)
        {
            if (book == null)
                throw (new ArgumentNullException("parameter missing"));

            _bookRepository.Update(book);
        }
        /// <summary>
        /// Deletes an book
        /// </summary>
        /// <param name="book">Book</param>
        public virtual void DeleteBook(Book book)
        {
            if (book == null)
                throw (new ArgumentNullException("parameter missing"));

            _bookRepository.Delete(book);
        }

        public virtual void BookLibraryExists(int bookId, int libraryId)
        {
            //var query = from book in _libraryBookMappingRepository.Table
            //            orderby book.Id
            //            where book.BookId == bookId && book.LibraryId == libraryId
            //            select book;

            //from p in Product
            //join c in Catalog on c.Id equals p.CatalogId
            //join m in Manufacturer on m.Id equals p.ManufacturerId

            var query = from libraryBook in _libraryBookMappingRepository.Table
                        join library in _libraryRepository.Table on libraryBook.LibraryId equals library.Id
                        join book in _bookRepository.Table on libraryBook.BookId equals book.Id
                        where libraryId == libraryBook.LibraryId && bookId == libraryBook.BookId
                        select libraryBook;
        }

        #endregion
    }
}

