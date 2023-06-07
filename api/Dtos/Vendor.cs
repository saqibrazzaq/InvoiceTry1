using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class VendorRes
    {
        public int VendorId { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Mobile { get; set; }
        public string? TollFree { get; set; }
        public string? Website { get; set; }

        // Foreign key
        public int? CurrencyId { get; set; }
        public Currency? Currency { get; set; }

        public int? BusinessId { get; set; }
        public Business? Business { get; set; }
    }

    public class VendorReqEdit
    {
        [Required, MinLength(1)]
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Mobile { get; set; }
        public string? TollFree { get; set; }
        public string? Website { get; set; }

        // Foreign key
        public int? CurrencyId { get; set; }
        public int? BusinessId { get; set; }
        
    }

    public class VendorReqSearch : PagedReq
    {

    }
}
