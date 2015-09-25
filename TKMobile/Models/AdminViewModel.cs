using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using TKMobile.Core.Entities.User;

namespace TKMobile.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "RoleName")]
        public string Name { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }

    public class UserDetailsViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Họ và Tên")]
        public string FullName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Ngày sinh")]
        public string BirthDateString { get; set; }

        [Display(Name = "Giới tính")]
        public Gender Gender { get; set; }

        [Display(Name = "Thành phố")]
        public string City { get; set; }

        [Display(Name = "Di động")]
        public string PhoneNumber { get; set; }
    }
}