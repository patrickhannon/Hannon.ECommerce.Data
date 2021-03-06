using System;
using System.Collections.Generic;
using ECommerce.Data.Core;
using ECommerce.Data.Entities.Customers;
using ECommerce.Data.Entities.Stores;


namespace ECommerce.Data.Entities.Catalog
{
    /// <summary>
    /// Represents a product review
    /// </summary>
    public partial class ProductReview : BaseEntity
    {
        private ICollection<ProductReviewHelpfulness> _productReviewHelpfulnessEntries;
        private ICollection<ProductReviewReviewTypeMapping> _productReviewReviewTypeMappingEntries;

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public int CustomerId { get; set; }

        public override string ToString()
        {
            return $"{nameof(CustomerId)}: {CustomerId}, {nameof(ProductId)}: {ProductId}, {nameof(StoreId)}: {StoreId}, {nameof(IsApproved)}: {IsApproved}, {nameof(Title)}: {Title}, {nameof(ReviewText)}: {ReviewText}, {nameof(ReplyText)}: {ReplyText}, {nameof(CustomerNotifiedOfReply)}: {CustomerNotifiedOfReply}, {nameof(Rating)}: {Rating}, {nameof(HelpfulYesTotal)}: {HelpfulYesTotal}, {nameof(HelpfulNoTotal)}: {HelpfulNoTotal}, {nameof(CreatedOnUtc)}: {CreatedOnUtc}, {nameof(Customer)}: {Customer}, {nameof(Product)}: {Product}, {nameof(Store)}: {Store}";
        }

        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the store identifier
        /// </summary>
        public int StoreId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the content is approved
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the review text
        /// </summary>
        public string ReviewText { get; set; }

        /// <summary>
        /// Gets or sets the reply text
        /// </summary>
        public string ReplyText { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the customer is already notified of the reply to review
        /// </summary>
        public bool CustomerNotifiedOfReply { get; set; }

        /// <summary>
        /// Review rating
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Review helpful votes total
        /// </summary>
        public int HelpfulYesTotal { get; set; }

        /// <summary>
        /// Review not helpful votes total
        /// </summary>
        public int HelpfulNoTotal { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Gets the product
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// Gets or sets the store
        /// </summary>
        public virtual Store Store { get; set; }

        /// <summary>
        /// Gets the entries of product review helpfulness
        /// </summary>
        public virtual ICollection<ProductReviewHelpfulness> ProductReviewHelpfulnessEntries
        {
            get => _productReviewHelpfulnessEntries ?? (_productReviewHelpfulnessEntries = new List<ProductReviewHelpfulness>());
            protected set => _productReviewHelpfulnessEntries = value;
        }

        /// <summary>
        /// Gets the entries of product reviews
        /// </summary>
        public virtual ICollection<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappingEntries
        {
            get { return _productReviewReviewTypeMappingEntries ?? (_productReviewReviewTypeMappingEntries = new List<ProductReviewReviewTypeMapping>()); }
            protected set { _productReviewReviewTypeMappingEntries = value; }
        }
    }
}
