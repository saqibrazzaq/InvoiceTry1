using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class SalesTaxRes
    {
        public int SalesTaxId { get; set; }
        public string? Abbreviation { get; set; }
        public string? Description { get; set; }
        public string? TaxNumber { get; set; }
        public bool ShowTaxNumberOnInvoice { get; set; }

        public int? BusinessId { get; set; }
        public Business? Business { get; set; }
    }

    public class SalesTaxReqEdit
    {
        [Required, MinLength(1)]
        public string? Abbreviation { get; set; }
        public string? Description { get; set; }
        public string? TaxNumber { get; set; }
        public bool ShowTaxNumberOnInvoice { get; set; } = false;

        public int? BusinessId { get; set; }
        
    }

    public class SalesTaxReqSearch : PagedReq
    {

    }
}
