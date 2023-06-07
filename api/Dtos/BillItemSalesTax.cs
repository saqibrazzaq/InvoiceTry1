using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class BillItemSalesTaxRes
    {
        public int BillItemSalesTaxId { get; set; }

        // Foreign keys
        public int? BillItemId { get; set; }
        public BillItem? BillItem { get; set; }

        public int? SalesTaxId { get; set; }
        public SalesTax? SalesTax { get; set; }
    }

    public class BillItemSalesTaxReqEdit
    {
        // Foreign keys
        public int? BillItemId { get; set; }
        public int? SalesTaxId { get; set; }
        
    }

    public class BillItemSalesTaxReqSearch : PagedReq
    {

    }
}
