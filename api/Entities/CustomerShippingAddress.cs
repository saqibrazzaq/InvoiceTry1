using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("CustomerShippingAddress")]
    public class CustomerShippingAddress
    {
        [Key]
        public int CustomerShippingAddressId { get; set; }

        // Foreign keys
        public int? CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer? Customer { get; set; }

        public int? AddressId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Address? Address { get; set; }

        public string? ShipTo { get; set; }
        public string? Phone { get; set; }
        public string? DeliveryInstructions { get; set; }
    }
}
