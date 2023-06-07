using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class InvoiceItemSalesTaxRes
    {
        public int InvoiceItemSalesTaxId { get; set; }

        // Foreign keys
        public int? InvoiceItemId { get; set; }
        public InvoiceItem? InvoiceItem { get; set; }

        public int? SalesTaxId { get; set; }
        public SalesTax? SalesTax { get; set; }
    }

    public class InvoiceItemSalesTaxReqEdit
    {
        public int? InvoiceItemId { get; set; }
        public int? SalesTaxId { get; set; }
        
    }

    public class InvoiceItemSalesTaxReqSearch : PagedReq
    {

    }
}
