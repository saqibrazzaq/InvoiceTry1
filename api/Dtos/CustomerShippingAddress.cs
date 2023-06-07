using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class CustomerShippingAddressRes
    {
        public int CustomerShippingAddressId { get; set; }

        // Foreign keys
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int? AddressId { get; set; }
        public Address? Address { get; set; }

        public string? ShipTo { get; set; }
        public string? Phone { get; set; }
        public string? DeliveryInstructions { get; set; }
    }

    public class CustomerShippingAddressReqEdit
    {
        public int? CustomerId { get; set; }
        public int? AddressId { get; set; }
        
        public string? ShipTo { get; set; }
        public string? Phone { get; set; }
        public string? DeliveryInstructions { get; set; }
    }

    public class CustomerShippingAddressReqSearch : PagedReq
    {

    }
}
