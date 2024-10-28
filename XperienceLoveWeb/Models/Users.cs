using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace XperienceLoveWeb.Models
{
    public class Users
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }
        [Required]
        public string Adress{ get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateOnly Birthdate { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Sexual_Orientation { get; set; }
    }
}
