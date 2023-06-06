using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("ServiceSalesTax")]
    public class ServiceSalesTax
    {
        [Key]
        public int ServiceSalesTaxId { get; set; }
        
        // Foreign keys
        public int? ServiceId { get; set; }
        [ForeignKey(nameof(ServiceId))]
        public Service? Service { get; set; }

        public int? SalesTaxId { get; set; }
        [ForeignKey(nameof(SalesTaxId))]
        public SalesTax? SalesTax { get; set; }
    }
}
