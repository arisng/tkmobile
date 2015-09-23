using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobile.Core.Entities.Catalog;

namespace TKMobile.Data.Mapping.Catalog
{
    public partial class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(400);
            Property(c => c.MetaKeywords).HasMaxLength(400);
            Property(c => c.MetaTitle).HasMaxLength(400);
            Property(c => c.PriceRanges).HasMaxLength(400);
        }
    }
}
