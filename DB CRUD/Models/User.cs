using System.ComponentModel.DataAnnotations;

namespace DB_CRUD.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }   
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public string Password { get; set; }
    }
}
