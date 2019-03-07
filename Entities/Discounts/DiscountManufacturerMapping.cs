using ECommerce.Data.Entities.Catalog;


namespace ECommerce.Data.Entities.Discounts
{
    /// <summary>
    /// Represents a discount-manufacturer mapping class
    /// </summary>
    public partial class DiscountManufacturerMapping 
    {
        /// <summary>
        /// Gets or sets the discount identifier
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer identifier
        /// </summary>
        public int ManufacturerId { get; set; }

        /// <summary>
        /// Gets or sets the discount
        /// </summary>
        public virtual Discount Discount { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer
        /// </summary>
        public virtual Manufacturer Manufacturer { get; set; }
    }
}