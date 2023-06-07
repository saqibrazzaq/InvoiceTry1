using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class CustomerBillingAddressRes
    {
        public int CustomerBillingAddressId { get; set; }

        // Foreign keys
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int? AddressId { get; set; }
        public Address? Address { get; set; }
    }

    public class CustomerBillingAddressReqEdit
    {
        public int? CustomerId { get; set; }
        public int? AddressId { get; set; }
        
    }

    public class CustomerBillingAddressReqSearch : PagedReq
    {

    }
}
