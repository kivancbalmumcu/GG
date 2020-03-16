namespace GG.Core.Entities.Books
{
    using GG.Core.Entities.Authors;
    using GG.Core.Entities.Libraries;
    using GG.Core.Entities.Publishers;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a Book
    /// </summary>
    public partial class Book : BaseEntity
    {
        #region Fields

        //private IList<Library> _libraries;
        //private ICollection<LibraryBookMapping> _libraryBookMappings;

        //private IList<Author> _authors;
        //private ICollection<AuthorBookMapping> _authorBookMappings;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the entity InternationalStandardBookNumber
        /// </summary>
        public int InternationalStandardBookNumber { get; set; }

        /// <summary>
        /// Gets or sets the InternationalStandardBookNumber
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the PublishedDate
        /// </summary>
        public DateTime PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the PageCount
        /// </summary>
        public int PageCount { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the Publisher identifier
        /// </summary>
        public int PublisherId { get; set; }

        /// <summary>
        /// Gets or sets the Publisher
        /// </summary>
        public virtual Publisher Publisher { get; set; }

        public virtual IList<Library> Library { get; set; }

        ///// <summary>
        ///// Gets or sets Authors
        ///// </summary>
        //public virtual IList<Author> Authors
        //{
        //    get => _authors ?? (_authors = _authorBookMappings.Select(mapping => mapping.Author).ToList());
        //}

        ///// <summary>
        ///// Gets or sets AuthorBookMappings
        ///// </summary>
        //public virtual ICollection<AuthorBookMapping> AuthorBookMappings
        //{
        //    get => _authorBookMappings ?? (_authorBookMappings = new List<AuthorBookMapping>());
        //    protected set => _authorBookMappings = value;
        //}

        ///// <summary>
        ///// Gets or sets Libraries
        ///// </summary>
        //public virtual IList<Library> Libraries
        //{
        //    get => _libraries ?? (_libraries = _libraryBookMappings.Select(mapping => mapping.Library).ToList());
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
