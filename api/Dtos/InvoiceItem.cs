using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class InvoiceItemRes
    {
        public int InvoiceItemId { get; set; }

        // Foreign keys
        public int? InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }

        public int? ProductId { get; set; }
        public Product? Product { get; set; }

        public string? Description { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
    }

    public class InvoiceItemReqEdit
    {
        public int? InvoiceId { get; set; }
        public int? ProductId { get; set; }
        
        public string? Description { get; set; }
        public double Quantity { get; set; } = 1;
        public double Price { get; set; } = 0;
    }

    public class InvoiceItemReqSearch : PagedReq
    {

    }
}
