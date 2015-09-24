using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TKMobile.Core.Entities.User;

namespace TKMobile.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Tên không được để trống")]
        [Display(Name = "Tên *")]
        [StringLength(100, ErrorMessage = "Tên {0} phải có ít nhất {2} kí tự.", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Họ và Đệm không được để trống")]
        [StringLength(100, ErrorMessage = "Họ và Đệm {0} phải có ít nhất {2} kí tự.", MinimumLength = 5)]
        [Display(Name = "Họ và Đệm *")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Email không hợp lệ")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress]
        [Display(Name = "Email *")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày Sinh")]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống")]
        [Display(Name = "Giới tính *")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "mật khẩu không được để trống")]
        [StringLength(100, ErrorMessage = "Mật khẩu {0} phải có ít nhất {2} kí tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu *")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu *")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu không hợp lệ")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}