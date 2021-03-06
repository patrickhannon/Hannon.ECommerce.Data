using ECommerce.Data.Core;
using ECommerce.Data.Entities.Media;

namespace ECommerce.Data.Entities.Catalog
{
    /// <summary>
    /// Represents a product picture mapping
    /// </summary>
    public partial class ProductPicture : BaseEntity
    {
        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the picture identifier
        /// </summary>
        public int PictureId { get; set; }

        public override string ToString()
        {
            return $"{nameof(ProductId)}: {ProductId}, {nameof(PictureId)}: {PictureId}, {nameof(DisplayOrder)}: {DisplayOrder}";
        }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
        
        /// <summary>
        /// Gets the picture
        /// </summary>
        public virtual Picture Picture { get; set; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual Product Product { get; set; }
    }
}
