using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("InvoiceItem")]
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemId { get; set; }

        // Foreign keys
        public int? InvoiceId { get; set; }
        [ForeignKey(nameof(InvoiceId))]
        public Invoice? Invoice { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }

        public string? Description { get; set; }
        public double Quantity { get; set; } = 1;
        public double Price { get; set; } = 0;
    }
}
