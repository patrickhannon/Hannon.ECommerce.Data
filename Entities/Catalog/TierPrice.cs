using System;
using ECommerce.Data.Core;
using ECommerce.Data.Entities.Customers;

namespace ECommerce.Data.Entities.Catalog
{
    /// <summary>
    /// Represents a tier price
    /// </summary>
    public partial class TierPrice : BaseEntity
    {
        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the store identifier (0 - all stores)
        /// </summary>
        public int StoreId { get; set; }

        public override string ToString()
        {
            return $"{nameof(ProductId)}: {ProductId}, {nameof(StoreId)}: {StoreId}, {nameof(CustomerRoleId)}: {CustomerRoleId}, {nameof(Quantity)}: {Quantity}, {nameof(Price)}: {Price}, {nameof(StartDateTimeUtc)}: {StartDateTimeUtc}, {nameof(EndDateTimeUtc)}: {EndDateTimeUtc}";
        }

        /// <summary>
        /// Gets or sets the customer role identifier
        /// </summary>
        public int? CustomerRoleId { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the start date and time in UTC
        /// </summary>
        public DateTime? StartDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the end date and time in UTC
        /// </summary>
        public DateTime? EndDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the product
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets the customer role
        /// </summary>
        public virtual CustomerRole CustomerRole { get; set; }
    }
}
