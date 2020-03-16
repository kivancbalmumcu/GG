namespace GG.Service.Libraries
{
    using GG.Core.Entities.Libraries;
    using GG.Data.EfRepository;
    using System;

    public partial class LibraryService : ILibraryService
    {
        #region Fields

        private readonly IRepository<Library> _libraryRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public LibraryService()
        {
            this._libraryRepository = new Repository<Library>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an address by Library identifier
        /// </summary>
        /// <param name="id">Library identifier</param>
        /// <returns>Library</returns>
        public virtual Library GetLibraryById(int id)
        {

            if (id == 0)
                throw (new ArgumentNullException("parameter missing"));

            var library = _libraryRepository.GetById(id);

            return library;
        }

        /// <summary>
        /// Inserts an library
        /// </summary>
        /// <param name="library">Library</param>
        public virtual void InsertLibrary(Library library)
        {
            if (library == null)
                throw (new ArgumentNullException("parameter missing"));

            _libraryRepository.Insert(library);
        }

        /// <summary>
        /// Updates an library
        /// </summary>
        /// <param name="library">Library</param>
        public virtual void UpdateLibrary(Library library)
        {
            if (library == null)
                throw (new ArgumentNullException("parameter missing"));

            _libraryRepository.Update(library);
        }

        /// <summary>
        /// Deletes an library
        /// </summary>
        /// <param name="library">Library</param>
        public virtual void DeleteLibrary(Library library)
        {
            if (library == null)
                throw (new ArgumentNullException("parameter missing"));

            _libraryRepository.Delete(library);
        }

        #endregion
    }
}

