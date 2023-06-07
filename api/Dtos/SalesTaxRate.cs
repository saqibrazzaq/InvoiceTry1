using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class SalesTaxRateRes
    {
        public int SalesTaxRateId { get; set; }
        public double RatePercent { get; set; }
        public DateTime EffectiveDate { get; set; }

        // Foreign keys
        public int? SalesTaxId { get; set; }
        public SalesTax? SalesTax { get; set; }
    }

    public class SalesTaxRateReqEdit
    {
        [Required]
        public double RatePercent { get; set; }
        [Required]
        public DateTime EffectiveDate { get; set; } = DateTime.MinValue;

        public int? SalesTaxId { get; set; }
        
    }

    public class SalesTaxRateReqSearch : PagedReq
    {

    }
}
