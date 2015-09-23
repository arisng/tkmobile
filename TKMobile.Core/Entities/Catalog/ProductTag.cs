using System.Collections.Generic;

namespace TKMobile.Core.Entities.Catalog
{
    public partial class ProductTag : BaseEntity
    {
        private ICollection<Product> products;

        public string Name { get; set; }

        public virtual ICollection<Product> Products
        {
            get { return products ?? (products = new List<Product>()); }
            set { products = value; }
        }
    }
}
