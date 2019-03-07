using ECommerce.Data.Entities.Configuration;


namespace ECommerce.Data.Entities.Messages
{
    /// <summary>
    /// Email account settings
    /// </summary>
    public class EmailAccountSettings : ISettings
    {
        /// <summary>
        /// Gets or sets a store default email account identifier
        /// </summary>
        public int DefaultEmailAccountId { get; set; }
    }
}
