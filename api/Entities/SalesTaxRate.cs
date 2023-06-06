using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("SalesTaxRate")]
    [Index(nameof(SalesTaxRateId), nameof(EffectiveDate), IsUnique = true)]
    public class SalesTaxRate
    {
        [Key]
        public int SalesTaxRateId { get; set; }
        [Required]
        public double RatePercent { get; set; }
        [Required]
        public DateTime EffectiveDate { get; set; } = DateTime.MinValue;

        // Foreign keys
        public int? SalesTaxId { get; set; }
        [ForeignKey(nameof(SalesTaxId))]
        public SalesTax? SalesTax { get; set; }
    }
}
