namespace GG.Service.Publishers
{
    using GG.Core.Entities.Publishers;
    using GG.Data.EfRepository;
    using System;

    public partial class PublisherService : IPublisherService
    {
        #region Fields

        private readonly IRepository<Publisher> _publisherRepository;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public PublisherService()
        {
            this._publisherRepository = new Repository<Publisher>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an address by Publisher identifier
        /// </summary>
        /// <param name="id">Publisher identifier</param>
        /// <returns>Publisher</returns>
        public virtual Publisher GetPublisherById(int id)
        {

            if (id == 0)
                throw (new ArgumentNullException("parameter missing"));

            var publisher = _publisherRepository.GetById(id);

            return publisher;
        }

        /// <summary>
        /// Inserts an publisher
        /// </summary>
        /// <param name="publisher">Publisher</param>
        public virtual void InsertPublisher(Publisher publisher)
        {
            if (publisher == null)
                throw (new ArgumentNullException("parameter missing"));

            _publisherRepository.Insert(publisher);
        }

        /// <summary>
        /// Updates an publisher
        /// </summary>
        /// <param name="publisher">Publisher</param>
        public virtual void UpdatePublisher(Publisher publisher)
        {
            if (publisher == null)
                throw (new ArgumentNullException("parameter missing"));

            _publisherRepository.Update(publisher);
        }

        /// <summary>
        /// Deletes an publisher
        /// </summary>
        /// <param name="publisher">Publisher</param>
        public virtual void DeletePublisher(Publisher publisher)
        {
            if (publisher == null)
                throw (new ArgumentNullException("parameter missing"));

            _publisherRepository.Delete(publisher);
        }

        #endregion
    }
}

