using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("Business")]
    public class Business
    {
        [Key]
        public int BusinessId { get; set; }
        [Required, MinLength(2)]
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Mobile { get; set; }
        public string? TollFree { get; set; }
        public string? Website { get; set; }

        // Foreign keys
        public int? AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Address? Address { get; set; }

        public int? CurrencyId { get; set; }
        [ForeignKey(nameof(CurrencyId))]
        public Currency? Currency { get; set; }

        public int? ProfileId { get; set; }
        [ForeignKey(nameof(ProfileId))]
        public Profile? Profile { get; set; }
    }
}
