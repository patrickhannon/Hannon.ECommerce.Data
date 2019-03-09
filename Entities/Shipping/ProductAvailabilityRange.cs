using ECommerce.Data.Core;
using ECommerce.Data.Entities.Localization;

namespace ECommerce.Data.Entities.Shipping
{
    /// <summary>
    /// Represents a product availability range
    /// </summary>
    public partial class ProductAvailabilityRange : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}