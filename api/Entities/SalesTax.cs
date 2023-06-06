using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("SalesTax")]
    public class SalesTax
    {
        [Key] 
        public int SalesTaxId { get; set; }
        [Required,MinLength(1)]
        public string? Abbreviation { get; set; }
        public string? Description { get; set; }
        public string? TaxNumber { get; set; }
        public bool ShowTaxNumberOnInvoice { get; set; } = false;

        public int? BusinessId { get; set; }
        [ForeignKey(nameof(BusinessId))]
        public Business? Business { get; set; }

    }
}
