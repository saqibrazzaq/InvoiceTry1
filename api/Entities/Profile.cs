using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("Profile")]
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        [Required, MinLength(1)]
        public string? FirstName { get; set; }
        [Required, MinLength(1)]
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;

        // Child tables
        public IList<Business>? Businesses { get; set; }
    }
}
