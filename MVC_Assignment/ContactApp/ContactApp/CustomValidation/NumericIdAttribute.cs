using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ContactApp.CustomValidation
{
    public class NumericIdAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value != null)
            {
                string val = value.ToString();

                if (!Regex.IsMatch(val, @"^\d+$"))
                {
                    return new ValidationResult("Id must contain only numbers");
                }
            }
            return ValidationResult.Success;
        }
    }
}
