namespace GG.Core.Entities.Borroweds
{
    using GG.Core.Entities.Books;
    using GG.Core.Entities.Libraries;
    using GG.Core.Entities.Users;
    using System;

    /// <summary>
    /// Represents a Borrowed
    /// </summary>
    public partial class Borrowed : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the BorrowedDate
        /// </summary>
        public DateTime BorrowedDate { get; set; }

        /// <summary>
        /// Gets or sets the IsRecieved
        /// </summary>
        public bool IsRecieved { get; set; }

        /// <summary>
        /// Gets or sets the RecievedDate
        /// </summary>
        public DateTime? RecievedDate { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the Library identifier
        /// </summary>
        public int ApplicationUserId { get; set; }

        /// <summary>
        /// Gets or sets the Library
        /// </summary>
        public virtual ApplicationUser ApplicationUser { get; set; }

        /// <summary>
        /// Gets or sets the Library identifier
        /// </summary>
        public int LibraryId { get; set; }

        /// <summary>
        /// Gets or sets the Library
        /// </summary>
        public virtual Library Library { get; set; }

        /// <summary>
        /// Gets or sets the Book identifier
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets the Book
        /// </summary>
        public virtual Book Book { get; set; }

        #endregion
    }
}
