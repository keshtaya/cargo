using System.ComponentModel.DataAnnotations;

namespace CargoCarApi.DTOs
{
    public class RegistrationForm
    {
        [Required]
        [MinLength(3, ErrorMessage = "The name is too short!")]  
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        public required string Phone { get; set; }

        [Required]
        public required string Password { get; set; }

        [Required]
        [Url]
        public string? ImageUrl { get; set; }
    }
}
