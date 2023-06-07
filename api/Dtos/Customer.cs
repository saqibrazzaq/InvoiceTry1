using api.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using api.Paging;

namespace api.Dtos
{
    public class CustomerRes
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? AccountNumber { get; set; }
        public string? Website { get; set; }
        public string? Notes { get; set; }

        // Foreign Keys
        public int? CurrencyId { get; set; }
        public Currency? Currency { get; set; }

        public int? BusinessId { get; set; }
        public Business? Business { get; set; }
    }

    public class CustomerReqEdit
    {
        [Required, MinLength(1)]
        public string? Name { get; set; }
        public string? AccountNumber { get; set; }
        public string? Website { get; set; }
        public string? Notes { get; set; }

        // Foreign Keys
        public int? CurrencyId { get; set; }
        public int? BusinessId { get; set; }
        
    }

    public class CustomerReqSearch : PagedReq
    {

    }
}
