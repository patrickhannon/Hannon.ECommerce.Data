using ECommerce.Data.Core;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Catalog;

namespace ECommerce.Data.Entities
{ 
    /// <summary>
    /// Represents a product-product tag mapping class
    /// </summary>
    public class ProductProductTagMapping : BaseEntity
    {
        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the product tag identifier
        /// </summary>
        public int ProductTagId { get; set; }

        public override string ToString()
        {
            return $"{nameof(ProductId)}: {ProductId}, {nameof(ProductTagId)}: {ProductTagId}, {nameof(Product)}: {Product}";
        }

        /// <summary>
        /// Gets or sets the product
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets the product tag
        /// </summary>
        public virtual ProductTag ProductTag { get; set; }
    }
}