using System.ComponentModel.DataAnnotations;

namespace BookStoreApplication.Helpers
{
    public class MyCustomValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {

            }
            return new ValidationResult("Value is empty");
        }
    }
}
