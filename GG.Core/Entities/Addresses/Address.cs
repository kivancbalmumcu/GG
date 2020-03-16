namespace GG.Core.Entities.Addresses
{
    /// <summary>
    /// Represents an Address
    /// </summary>
    public partial class Address : BaseEntity
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Street
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the Neighborhood
        /// </summary>
        public string Neighborhood { get; set; }

        /// <summary>
        /// Gets or sets the BuildingNumber
        /// </summary>
        public int BuildingNumber { get; set; }

        /// <summary>
        /// Gets or sets the FloorNumber
        /// </summary>
        public int FloorNumber { get; set; }

        /// <summary>
        /// Gets or sets the PostCode
        /// </summary>
        public int PostCode { get; set; }

        /// <summary>
        /// Gets or sets the District
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// Gets or sets the Province
        /// </summary>
        public string Province { get; set; }

        #endregion
    }
}
