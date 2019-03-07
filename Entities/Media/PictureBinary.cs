using ECommerce.Data.Entities.Media;

namespace ECommerce.Data.Entities.Media
{
    /// <summary>
    /// Represents a picture binary data
    /// </summary>
    public partial class PictureBinary
    {
        /// <summary>
        /// Gets or sets the picture binary
        /// </summary>
        public byte[] BinaryData { get; set; }
       
        /// <summary>
        /// Gets or sets the picture identifier
        /// </summary>
        public int PictureId { get; set; }

        /// <summary>
        /// Gets or sets the picture
        /// </summary>
        public virtual Picture Picture { get; set; }
    }
}