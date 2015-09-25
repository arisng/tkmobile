using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TKMobile.Core.Entities.User
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()
        {
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }

        public ApplicationUser(string userName)
            : base()
        {
            UserName = userName;
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Họ và Tên")]
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", LastName, FirstName);
            }
        }

        public DateTime BirthDate { get; set; }

        [NotMapped]
        [Display(Name = "Ngày sinh")]
        public string BirthDateString
        {
            get
            {
                return BirthDate.ToShortDateString();
            }
        }

        [Required]
        [Display(Name = "Giới tính")]
        public Gender Gender { get; set; }

        [Display(Name = "Thành phố")]
        public string City { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        //[ForeignKey("Address")]
        //public int AddressId { get; set; }

        //[ForeignKey("AddressId")]
        //public virtual Address Address { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public enum Gender
    {
        Nam = 1,
        Nữ = 2
    }
}
