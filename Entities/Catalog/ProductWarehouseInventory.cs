

using ECommerce.Data.Core;
using ECommerce.Data.Entities.Shipping;

namespace ECommerce.Data.Entities.Catalog
{ 
    /// <summary>
    /// Represents a record to manage product inventory per warehouse
    /// </summary>
public partial class ProductWarehouseInventory : BaseEntity
    {
        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the warehouse identifier
        /// </summary>
        public int WarehouseId { get; set; }

        /// <summary>
        /// Gets or sets the stock quantity
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Gets or sets the reserved quantity (ordered but not shipped yet)
        /// </summary>
        public int ReservedQuantity { get; set; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets the warehouse
        /// </summary>
        public virtual Warehouse Warehouse { get; set; }

        public override string ToString()
        {
            return $"{nameof(ProductId)}: {ProductId}, {nameof(WarehouseId)}: {WarehouseId}, {nameof(StockQuantity)}: {StockQuantity}, {nameof(ReservedQuantity)}: {ReservedQuantity}";
        }
    }
}
