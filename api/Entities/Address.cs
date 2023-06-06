using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [Required, MinLength(5)]
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }

        // Foreign keys
        public int? StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public State? State { get; set; }
    }
}
