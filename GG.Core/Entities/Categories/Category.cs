namespace GG.Core.Entities.Categories
{
    /// <summary>
    /// Represents a Category
    /// </summary>
    public partial class Category : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public string Name { get; set; }

        #endregion
    }
}
