
namespace GG.Core.Entities.Categories
{
    using GG.Core.Entities.Books;

    /// <summary>
    /// Represents a CategoryBookMapping
    /// </summary>
    public partial class CategoryBookMapping : BaseEntity
    {
        #region Navigation Properties

        /// <summary>
        /// Gets or sets Category identifier
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets Category
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// Gets or sets Book identifier
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets Book
        /// </summary>
        public virtual Book Book { get; set; }

        #endregion
    }
}
