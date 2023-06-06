using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("Bill")]
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        public DateTime BillDate { get; set; } = DateTime.UtcNow;
        public string? BillNumber { get; set; }
        public DateTime DueDate { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
        public string? POSO { get; set; }

        // Foreign keys
        public int? VendorId { get; set; }
        [ForeignKey(nameof(VendorId))]
        public Vendor? Vendor { get; set; }

        public int? BusinessId { get; set; }
        [ForeignKey(nameof(BusinessId))]
        public Business? Business { get; set; }

        public int? CurrencyId { get; set; }
        [ForeignKey(nameof(CurrencyId))]
        public Currency? Currency { get; set; }

        // Child tables
        public IList<BillItem>? BillItems { get; set; }
    }
}
