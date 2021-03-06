
using ECommerce.Data.Entities.Catalog;

namespace ECommerce.Data.Entities.Discounts
{
    /// <summary>
    /// Represents a discount-category mapping class
    /// </summary>
    public partial class DiscountCategoryMapping 
    {
        /// <summary>
        /// Gets or sets the discount identifier
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets the category identifier
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the discount
        /// </summary>
        public virtual Discount Discount { get; set; }

        /// <summary>
        /// Gets or sets the category
        /// </summary>
        public virtual Category Category { get; set; }
    }
}