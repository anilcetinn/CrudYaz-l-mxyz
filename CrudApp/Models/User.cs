using System.ComponentModel.DataAnnotations;

namespace CrudApp.Models
{
    public class User
    {
        public int Id { get; set; } // Primary Key

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

      
    }
}
