namespace GG.Core.Entities.Libraries
{
    using GG.Core.Entities.Books;

    /// <summary>
    /// Represents a LibraryBookMapping
    /// </summary>
    public partial class LibraryBookMapping : BaseEntity
    {
        #region Navigation Properties

        /// <summary>
        /// Gets or sets Book identifier
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets Book
        /// </summary>
        public virtual Book Book { get; set; }

        /// <summary>
        /// Gets or sets Library identifier
        /// </summary>
        public int LibraryId { get; set; }

        /// <summary>
        /// Gets or sets Library
        /// </summary>
        public virtual Library Library { get; set; }

        #endregion
    }
}
