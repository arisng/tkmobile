using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobile.Core.Entities.Seo;

namespace TKMobile.Data.Mapping.Seo
{
    public partial class UrlRecordMap : EntityTypeConfiguration<UrlRecord>
    {
        public UrlRecordMap()
        {
            ToTable("UrlRecord");
            HasKey(r => r.Id);

            Property(ur => ur.EntityName).IsRequired().HasMaxLength(400);
            Property(ur => ur.Slug).IsRequired().HasMaxLength(400);
        }
    }
}
