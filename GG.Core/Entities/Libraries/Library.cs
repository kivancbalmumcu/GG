
namespace GG.Core.Entities.Libraries
{
    using GG.Core.Entities.Books;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a Library
    /// </summary>
    public partial class Library : BaseEntity
    {
        #region Fields

        //private IList<Book> _books;
        //private ICollection<LibraryBookMapping> _libraryBookMappings;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Address identifier
        /// </summary>
        public int AddressId { get; set; }

        #endregion

        #region Navigation Properties

        public virtual IList<Book> Books { get; set; }

        ///// <summary>
        ///// Gets or sets Books
        ///// </summary>
        //public virtual IList<Book> Books
        //{
        //    get => _books ?? (_books = _libraryBookMappings.Select(mapping => mapping.Book).ToList());
        //}

        ///// <summary>
        ///// Gets or sets LibraryBookMappings
        ///// </summary>
        //public virtual ICollection<LibraryBookMapping> LibraryBookMappings
        //{
        //    get => _libraryBookMappings ?? (_libraryBookMappings = new List<LibraryBookMapping>());
        //    protected set => _libraryBookMappings = value;
        //}

        #endregion
    }
}
