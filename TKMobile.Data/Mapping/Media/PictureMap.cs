using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMobile.Core.Entities.Media;

namespace TKMobile.Data.Mapping.Media
{
    public partial class PictureMap : EntityTypeConfiguration<Picture>
    {
        public PictureMap()
        {
            ToTable("Picture");
            HasKey(p => p.Id);
            Property(p => p.PictureBinary).IsMaxLength();
            Property(p => p.MimeType).IsRequired().HasMaxLength(40);
            Property(p => p.SeoFileName).HasMaxLength(300);
        }
    }
}
