using System.Collections.Generic;
using ECommerce.Data.Core;
using ECommerce.Data.Entities.Localization;

namespace ECommerce.Data.Entities.Catalog
{
    /// <summary>
    /// Represents a specification attribute
    /// </summary>
    public partial class SpecificationAttribute : BaseEntity
    {
        private ICollection<SpecificationAttributeOption> _specificationAttributeOptions;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the specification attribute options
        /// </summary>
        public virtual ICollection<SpecificationAttributeOption> SpecificationAttributeOptions
        {
            get => _specificationAttributeOptions ?? (_specificationAttributeOptions = new List<SpecificationAttributeOption>());
            protected set => _specificationAttributeOptions = value;
        }
    }
}
