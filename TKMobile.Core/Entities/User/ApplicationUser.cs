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

        public DateTime BirthDate { get; set; }

        [Required]
        public Gender Gender { get; set; }

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
        Male = 1,
        Female = 2
    }
}
