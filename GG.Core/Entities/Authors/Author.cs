using GG.Core.Entities.Books;
using System.Collections.Generic;
using System.Linq;

namespace GG.Core.Entities.Authors
{
    /// <summary>
    /// Represents an Author
    /// </summary>
    public partial class Author : BaseEntity
    {
        #region Fields

        //private IList<Book> _books;
        private ICollection<AuthorBookMapping> _authorBookMappings;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Firstname
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or sets the Middlename
        /// </summary>
        public string Middlename { get; set; }

        /// <summary>
        /// Gets or sets the Lastname
        /// </summary>
        public string Lastname { get; set; }

        #endregion

        #region Navigation properties

        /// <summary>
        /// Gets or sets Books
        /// </summary>
        //public virtual IList<Book> Books
        //{
        //    get => _books ?? (_books = _authorBookMappings.Select(mapping => mapping.Book).ToList());
        //}

        /// <summary>
        /// Gets or sets AuthorBookMappings
        /// </summary>
        public virtual ICollection<AuthorBookMapping> AuthorBookMappings
        {
            get => _authorBookMappings ?? (_authorBookMappings = new List<AuthorBookMapping>());
            protected set => _authorBookMappings = value;
        }

        #endregion
    }
}
