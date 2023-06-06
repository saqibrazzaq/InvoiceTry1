using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("BillItem")]
    public class BillItem
    {
        [Key]
        public int BillItemId { get; set; }

        public int? BillId { get; set; }
        [ForeignKey(nameof(BillId))]
        public Bill? Bill { get; set; }

        public int? ServiceId { get; set; }
        [ForeignKey(nameof(ServiceId))]
        public Service? Service { get; set; }

        public string? Description { get; set; }
        public double Quantity { get; set; } = 1;
        public double Price { get; set; } = 0;
    }
}
