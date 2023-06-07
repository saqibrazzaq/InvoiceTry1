using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class ServiceSalesTaxRes
    {
        public int ServiceSalesTaxId { get; set; }

        // Foreign keys
        public int? ServiceId { get; set; }
        public Service? Service { get; set; }

        public int? SalesTaxId { get; set; }
        public SalesTax? SalesTax { get; set; }
    }

    public class ServiceSalesTaxReqEdit
    {
        public int ServiceSalesTaxId { get; set; }

        // Foreign keys
        public int? ServiceId { get; set; }
        public int? SalesTaxId { get; set; }
        
    }

    public class ServiceSalesTaxReqSearch : PagedReq
    {

    }
}
