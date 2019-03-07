namespace ECommerce.Data.Entities.Catalog
{
    /// <summary>
    /// Represents a manufacturer template
    /// </summary>
    public partial class ManufacturerTemplate 
    {
        /// <summary>
        /// Gets or sets the template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the view path
        /// </summary>
        public string ViewPath { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
