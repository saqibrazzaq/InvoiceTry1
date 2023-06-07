using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class BillRes
    {
        public int BillId { get; set; }
        public DateTime BillDate { get; set; } = DateTime.UtcNow;
        public string? BillNumber { get; set; }
        public DateTime DueDate { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
        public string? POSO { get; set; }

        // Foreign keys
        public int? VendorId { get; set; }
        public Vendor? Vendor { get; set; }

        public int? BusinessId { get; set; }
        public Business? Business { get; set; }

        public int? CurrencyId { get; set; }
        public Currency? Currency { get; set; }

        // Child tables
        public IList<BillItem>? BillItems { get; set; }
    }

    public class BillReqEdit
    {
        public DateTime BillDate { get; set; } = DateTime.UtcNow;
        public string? BillNumber { get; set; }
        public DateTime DueDate { get; set; } = DateTime.UtcNow;
        public string? Notes { get; set; }
        public string? POSO { get; set; }

        // Foreign keys
        public int? VendorId { get; set; }
        public int? BusinessId { get; set; }
        public int? CurrencyId { get; set; }
        
    }

    public class BillReqSearch : PagedReq
    {

    }
}
