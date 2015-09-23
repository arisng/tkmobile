using System.Data.Entity.ModelConfiguration;
using TKMobile.Core.Entities.Catalog;

namespace TKMobile.Data.Mapping.Catalog
{
    public partial class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(400);
            Property(p => p.MetaKeywords).HasMaxLength(400);
            Property(p => p.MetaTitle).HasMaxLength(400);
            Property(p => p.Sku).HasMaxLength(400);
            Property(p => p.Price).HasPrecision(18, 4);

            Ignore(p => p.ProductType);
            Ignore(p => p.ProductCondition);

            HasMany(p => p.ProductTags)
                .WithMany(pt => pt.Products)
                .Map(m => m.ToTable("Product_ProductTag_Mapping"));
        }
    }
}
