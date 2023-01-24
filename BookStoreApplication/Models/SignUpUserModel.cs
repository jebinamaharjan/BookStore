using System.ComponentModel.DataAnnotations;

namespace BookStoreApplication.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please enter your Email")]
        [Display(Name ="Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter your Password")]
        [Compare("ConfirmPassword", ErrorMessage ="Passwor does not match")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Please re-type your Password")]
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
