using api.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using api.Paging;

namespace api.Dtos
{
    public class BusinessRes
    {
        public int BusinessId { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Mobile { get; set; }
        public string? TollFree { get; set; }
        public string? Website { get; set; }

        // Foreign keys
        public int? AddressId { get; set; }
        public Address? Address { get; set; }

        public int? CurrencyId { get; set; }
        public Currency? Currency { get; set; }

        public int? ProfileId { get; set; }
        public Profile? Profile { get; set; }
    }

    public class BusinessReqEdit
    {
        [Required, MinLength(2)]
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Mobile { get; set; }
        public string? TollFree { get; set; }
        public string? Website { get; set; }

        // Foreign keys
        public int? AddressId { get; set; }
        public int? CurrencyId { get; set; }
        public int? ProfileId { get; set; }
        
    }

    public class BusinessReqSearch : PagedReq
    {

    }
}
