using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("InvoiceItemSalesTax")]
    [Index(nameof(InvoiceItemId), nameof(SalesTaxId), IsUnique = true)]
    public class InvoiceItemSalesTax
    {
        [Key]
        public int InvoiceItemSalesTaxId { get; set; }

        // Foreign keys
        public int? InvoiceItemId { get; set; }
        [ForeignKey(nameof(InvoiceItemId))]
        public InvoiceItem? InvoiceItem { get; set; }

        public int? SalesTaxId { get; set; }
        [ForeignKey(nameof(SalesTaxId))]
        public SalesTax? SalesTax { get; set; }

    }
}
