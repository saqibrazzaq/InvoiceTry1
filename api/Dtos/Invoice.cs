using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class InvoiceRes
    {
        public int InvoiceId { get; set; }

        // Foreign keys
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int? BusinessId { get; set; }
        public Business? Business { get; set; }

        public string? InvoiceNumber { get; set; }
        public string? POSO { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentDue { get; set; }
    }

    public class InvoiceReqEdit
    {
        public int? CustomerId { get; set; }
        public int? BusinessId { get; set; }
        
        public string? InvoiceNumber { get; set; }
        public string? POSO { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.UtcNow;
        public DateTime PaymentDue { get; set; } = DateTime.UtcNow;
    }

    public class InvoiceReqSearch : PagedReq
    {

    }
}
