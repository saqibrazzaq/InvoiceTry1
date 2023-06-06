using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("CustomerContact")]
    public class CustomerContact
    {
        [Key]
        public int CustomerContactId { get; set; }
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
        [ForeignKey(nameof(CustomerId))]
        public Customer? Customer { get; set; }
    }
}
