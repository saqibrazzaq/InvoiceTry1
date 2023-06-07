using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class CustomerContactRes
    {
        public int CustomerContactId { get; set; }
        public bool IsPrimary { get; set; };
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? TollFree { get; set; }
        public string? Fax { get; set; }

        // Foreign keys
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }

    public class CustomerContactReqEdit
    {
        public bool IsPrimary { get; set; } = true;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? TollFree { get; set; }
        public string? Fax { get; set; }

        // Foreign keys
        public int? CustomerId { get; set; }
        
    }

    public class CustomerContactReqSearch : PagedReq
    {

    }
}
