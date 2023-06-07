using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class AddressRes
    {
        public int AddressId { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public int? StateId { get; set; }
        public StateRes? State { get; set; }
    }

    public class AddressReqEdit
    {
        [Required, MinLength(5)]
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }

        // Foreign keys
        public int? StateId { get; set; }
    }

    public class AddressReqSearch : PagedReq
    {

    }
}
