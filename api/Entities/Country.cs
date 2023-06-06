using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("Country")]
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required, MinLength(3)]
        public string? Name { get; set; }
        [Required, MinLength(3), MaxLength(3)]
        public string? Code { get; set; }

        // Child tables
        public IList<State>? States { get; set; }
    }
}
