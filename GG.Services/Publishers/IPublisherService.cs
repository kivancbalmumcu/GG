namespace GG.Service.Publishers
{
    using GG.Core.Entities.Publishers;

    /// <summary>
    /// Publisher service interface
    /// </summary>
    public partial interface IPublisherService
    {
        #region Methods
        /// <summary>
        /// Gets an publisher by identifier
        /// </summary>
        /// <param name="id">Publisher identifier</param>
        /// <returns>Publisher</returns>
        Publisher GetPublisherById(int id);

        /// <summary>
        /// Insters an publisher
        /// </summary>
        /// <param name="publisher">Publisher</param>
        void InsertPublisher(Publisher publisher);

        /// <summary>
        /// Updates an publisher
        /// </summary>
        /// <param name="publisher">Publisher</param>
        void UpdatePublisher(Publisher publisher);

        /// <summary>
        /// Deletes an publisher
        /// </summary>
        /// <param name="publisher">Publisher</param>
        void DeletePublisher(Publisher publisher);

        #endregion
    }
}
