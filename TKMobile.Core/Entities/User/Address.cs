using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKMobile.Core.Entities.User
{
    public partial class Address : BaseEntity
    {
        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }

        public string District { get; set; }

        public string Ward { get; set; }

        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get;set; }
    }
}
