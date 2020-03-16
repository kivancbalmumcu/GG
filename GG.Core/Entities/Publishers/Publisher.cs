namespace GG.Core.Entities.Publishers
{
    using GG.Core.Entities.Books;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a Publisher
    /// </summary>
    public partial class Publisher : BaseEntity
    {
        #region Fields

        private ICollection<Book> _books;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Address identifier
        /// </summary>
        public int AddressId { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets Books
        /// </summary>
        public virtual ICollection<Book> Books
        {
            get => _books ?? (_books = new List<Book>());
            protected set => _books = value;
        }

        #endregion
    }
}