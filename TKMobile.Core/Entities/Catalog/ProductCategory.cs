namespace TKMobile.Core.Entities.Catalog
{
    /// <summary>
    /// Represents a product category mapping
    /// </summary>
    public partial class ProductCategory : BaseEntity
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the product is featured
        /// </summary>
        public bool IsFeaturedProduct { get; set; }

        public virtual Product Product { get; set; }

        public virtual Category Category { get; set; }
    }
}
