using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobile.Core.Entities.Catalog;

namespace TKMobile.Data.Mapping.Catalog
{
    public partial class ProductCommentMap : EntityTypeConfiguration<ProductComment>
    {
        public ProductCommentMap()
        {
            ToTable("ProductComment");
            HasKey(pc => pc.Id);

            HasRequired(pc => pc.Product)
                .WithMany(p => p.ProductComments)
                .HasForeignKey(pc => pc.ProductId);

            HasRequired(pc => pc.Customer)
                .WithMany()
                .HasForeignKey(pc => pc.CustomerId);
        }
    }
}
