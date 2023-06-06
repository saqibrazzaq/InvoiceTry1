using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        // Foreign keys
        public int? CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer? Customer { get; set; }

        public int? BusinessId { get; set; }
        [ForeignKey(nameof(BusinessId))]
        public Business? Business { get; set; }

        public string? InvoiceNumber { get; set; }
        public string? POSO { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.UtcNow;
        public DateTime PaymentDue { get; set; } = DateTime.UtcNow;

    }
}
