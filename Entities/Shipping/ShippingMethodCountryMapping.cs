using ECommerce.Data.Entities.Directory;

namespace ECommerce.Data.Entities.Shipping
{
    /// <summary>
    /// Represents a shipping method-country mapping class
    /// </summary>
    public partial class ShippingMethodCountryMapping
    { 
        /// <summary>
        /// Gets or sets the shipping method identifier
        /// </summary>
        public int ShippingMethodId { get; set; }

        /// <summary>
        /// Gets or sets the country identifier
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the shipping method
        /// </summary>
        public virtual ShippingMethod ShippingMethod { get; set; }

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public virtual Country Country { get; set; }
    }
}