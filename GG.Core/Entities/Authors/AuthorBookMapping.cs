using GG.Core.Entities.Books;

namespace GG.Core.Entities.Authors
{
    /// <summary>
    /// Represents an AuthorBookMapping
    /// </summary>
    public partial class AuthorBookMapping : BaseEntity
    {
        #region Navigation Properties

        /// <summary>
        /// Gets or sets the Author identifier
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the Book identifier
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets the Author
        /// </summary>
        public virtual Author Author { get; set; }

        /// <summary>
        /// Gets or sets the Book
        /// </summary>
        public virtual Book Book { get; set; }

        #endregion
    }
}
