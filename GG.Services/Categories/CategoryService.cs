namespace GG.Service.Categories
{
    using GG.Core.Entities.Categories;
using GG.Data.EfRepository;
using System;
    
    /// <summary>
    /// Category service
    /// </summary>
    public partial class CategoryService : ICategoryService
    {
        #region Fields

        private readonly IRepository<Category> _CategoryRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public CategoryService()
        {
            this._CategoryRepository = new Repository<Category>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an address by Category identifier
        /// </summary>
        /// <param name="id">Category identifier</param>
        /// <returns>Category</returns>
        public virtual Category GetCategoryById(int id)
        {

            if (id == 0)
                throw (new ArgumentNullException("parameter missing"));

            var Category = _CategoryRepository.GetById(id);

            return Category;
        }

        /// <summary>
        /// Inserts an Category
        /// </summary>
        /// <param name="Category">Category</param>
        public virtual void InsertCategory(Category Category)
        {
            if (Category == null)
                throw (new ArgumentNullException("parameter missing"));

            _CategoryRepository.Insert(Category);
        }

        /// <summary>
        /// Updates an Category
        /// </summary>
        /// <param name="Category">Category</param>
        public virtual void UpdateCategory(Category Category)
        {
            if (Category == null)
                throw (new ArgumentNullException("parameter missing"));

            _CategoryRepository.Update(Category);
        }

        /// <summary>
        /// Deletes an Category
        /// </summary>
        /// <param name="Category">Category</param>
        public virtual void DeleteCategory(Category Category)
        {
            if (Category == null)
                throw (new ArgumentNullException("parameter missing"));

            _CategoryRepository.Delete(Category);
        }

        #endregion
    }
}

