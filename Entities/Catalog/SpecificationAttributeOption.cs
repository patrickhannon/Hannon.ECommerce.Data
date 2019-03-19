﻿

using ECommerce.Data.Core;
using ECommerce.Data.Entities.Localization;

namespace ECommerce.Data.Entities.Catalog
{
    /// <summary>
    /// Represents a specification attribute option
    /// </summary>
    public class SpecificationAttributeOption : BaseEntity
    {
        /// <summary>
        /// Gets or sets the specification attribute identifier
        /// </summary>
        public int SpecificationAttributeId { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the color RGB value (used when you want to display "Color squares" instead of text)
        /// </summary>
        public string ColorSquaresRgb { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
        
        /// <summary>
        /// Gets or sets the specification attribute
        /// </summary>
        public virtual SpecificationAttribute SpecificationAttribute { get; set; }
    }
}
