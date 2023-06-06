using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required, MinLength(1)]
        public string? Name { get; set; }
        public string? AccountNumber { get; set; }
        public string? Website { get; set; }
        public string? Notes { get; set; }

        // Foreign Keys
        public int? CurrencyId { get; set; }
        [ForeignKey(nameof(CurrencyId))]
        public Currency? Currency { get; set; }

        public int? BusinessId { get; set; }
        [ForeignKey(nameof(BusinessId))]
        public Business? Business { get; set; }


    }
}
