using api.Paging;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class CurrencyRes
    {
        public int CurrencyId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
    }

    public class CurrencyReqEdit
    {
        [Required, MinLength(3), MaxLength(3)]
        public string? Code { get; set; }
        [Required, MinLength(3)]
        public string? Name { get; set; }
    }

    public class CurrencyReqSearch : PagedReq
    {

    }
}
