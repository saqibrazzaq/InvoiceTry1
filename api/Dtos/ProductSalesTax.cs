using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class ProductSalesTaxRes
    {
        public int ProductSalesTaxId { get; set; }

        // Foreign keys
        public int? ProductId { get; set; }
        public Product? Product { get; set; }

        public int? SalesTaxId { get; set; }
        public SalesTax? SalesTax { get; set; }
    }

    public class ProductSalesTaxReqEdit
    {
        public int ProductSalesTaxId { get; set; }

        // Foreign keys
        public int? ProductId { get; set; }
        public int? SalesTaxId { get; set; }
        
    }

    public class ProductSalesTaxReqSearch : PagedReq
    {

    }
}
