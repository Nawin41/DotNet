using System.ComponentModel.DataAnnotations;
using ContactApp.CustomValidation;

namespace ContactApp.Models
{
    public class Contact
    {
        [NumericId]
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
