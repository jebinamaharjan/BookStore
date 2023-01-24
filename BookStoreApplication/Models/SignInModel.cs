﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreApplication.Models
{
    public class SignInModel
    {
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]   
        public string Password { get; set; }
        [Display(Name ="Remeber Me")]
        public bool RememberMe{ get; set; }
    }
}
