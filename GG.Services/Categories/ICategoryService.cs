namespace GG.Service.Categories
{

    using GG.Core.Entities.Categories;

    /// <summary>
    /// Category service interface
    /// </summary>
    public partial interface ICategoryService
    {
        #region Methods
        /// <summary>
        /// Gets an category by identifier
        /// </summary>
        /// <param name="id">Category identifier</param>
        /// <returns>Category</returns>
        Category GetCategoryById(int id);

        /// <summary>
        /// Insters an category
        /// </summary>
        /// <param name="category">Category</param>
        void InsertCategory(Category category);

        /// <summary>
        /// Updates an category
        /// </summary>
        /// <param name="category">Category</param>
        void UpdateCategory(Category category);

        /// <summary>
        /// Deletes an category
        /// </summary>
        /// <param name="category">Category</param>
        void DeleteCategory(Category category);

        #endregion
    }
}
