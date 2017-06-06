using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Organizer.Models
{
    public class LoginModel
    {
        [Display(Name = "Email", ResourceType = typeof(Resources.Resource))]
        public string Email { get; set; }

        [Display(Name = "Password", ResourceType = typeof(Resources.Resource))]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class RegistrationModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "EmailRequired")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[a-z0-9.-]+\.((by)|(com)|(ru)|(net)|(eu))", ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "EmailException")]
        [Display(Name = "Email", ResourceType = typeof(Resources.Resource))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "UsernameRequired")]
        [Display(Name = "Username", ResourceType = typeof(Resources.Resource))]
        public string Username { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "PasswordRequired")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 8, ErrorMessageResourceName = "LengthPassword",
                  ErrorMessageResourceType = typeof(Resources.Resource))]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$", ErrorMessageResourceName = "ValidationPassword",
                  ErrorMessageResourceType = typeof(Resources.Resource))]
        [Display(Name = "Password", ResourceType = typeof(Resources.Resource))]
        public string Password { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "ConfirmPasswordRequired")]
        [Compare("Password", ErrorMessageResourceName = "ComparePassword",
                  ErrorMessageResourceType = typeof(Resources.Resource))]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Resource))]
        public string ConfirmPassword { get; set; }
    }

    public class UpdatePasswordModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                         ErrorMessageResourceName = "OldPasswordRequired")]
        [DataType(DataType.Password)]
        [Display(Name = "OldPassword", ResourceType = typeof(Resources.Resource))]
        public string OldPassword { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "NewPasswordRequired")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 8, ErrorMessageResourceName = "LengthPassword",
                  ErrorMessageResourceType = typeof(Resources.Resource))]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$", ErrorMessageResourceName = "ValidationPassword",
                  ErrorMessageResourceType = typeof(Resources.Resource))]
        [Display(Name = "NewPassword", ResourceType = typeof(Resources.Resource))]
        public string NewPassword { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "ConfirmPasswordRequired")]
        [Compare("NewPassword", ErrorMessageResourceName = "ComparePassword",
                  ErrorMessageResourceType = typeof(Resources.Resource))]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Resource))]
        public string ConfirmPassword { get; set; }
    }
}