using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobile.Core.Entities.Discounts;

namespace TKMobile.Data.Mapping.Discounts
{
    public partial class DiscountMap : EntityTypeConfiguration<Discount>
    {
        public DiscountMap()
        {
            ToTable("Discount");
            HasKey(d => d.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(200);
            Property(d => d.DiscountPercentage).HasPrecision(18, 4);
            Property(d => d.DiscountAmount).HasPrecision(18, 4);

            Ignore(d => d.DiscountType);

            HasMany(d => d.AppliedToCategories)
                .WithMany(c => c.AppliedDiscounts)
                .Map(m => m.ToTable("Discount_AppliedToCategories"));

            HasMany(dr => dr.AppliedToProducts)
                .WithMany(p => p.AppliedDiscounts)
                .Map(m => m.ToTable("Discount_AppliedToProducts"));
        }
    }
}
