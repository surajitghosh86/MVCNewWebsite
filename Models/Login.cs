using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_NewWebsite.Models
{
    public class Users
    {
        [Required(ErrorMessage = "Required!")]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage= "Required!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password and ComparePassword doesn't matched!")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Compare Password")]
        public string ComparePassword { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }

        [Range(18, 100)]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [MaxLength(12,ErrorMessage ="Maxlength is 12")]
        [MinLength(10, ErrorMessage = "Minlength is 10")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}