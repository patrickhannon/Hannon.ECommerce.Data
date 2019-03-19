using ECommerce.Data.Core;

namespace ECommerce.Data.Entities.Catalog
{
    /// <summary>
    /// Represents a product category mapping
    /// </summary>
    public class ProductCategory : BaseEntity
    {
        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the category identifier
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the product is featured
        /// </summary>
        public bool IsFeaturedProduct { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
        
        /// <summary>
        /// Gets the category
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual Product Product { get; set; }

        public override string ToString()
        {
            return $"{nameof(ProductId)}: {ProductId}, {nameof(CategoryId)}: {CategoryId}, {nameof(IsFeaturedProduct)}: {IsFeaturedProduct}, {nameof(DisplayOrder)}: {DisplayOrder}";
        }
    }
}
