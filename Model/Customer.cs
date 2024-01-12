using System.ComponentModel.DataAnnotations;

namespace Web_Api___Repository_Pattern.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(120)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(350)]
        public string Email { get; set; }
    }
}
