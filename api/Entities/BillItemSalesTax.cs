using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("BillItemSalesTax")]
    [Index(nameof(BillItemId), nameof(SalesTaxId), IsUnique = true)]
    public class BillItemSalesTax
    {
        [Key]
        public int BillItemSalesTaxId { get; set; }

        // Foreign keys
        public int? BillItemId { get; set; }
        [ForeignKey(nameof(BillItemId))]
        public BillItem? BillItem { get; set; }

        public int? SalesTaxId { get; set; }
        [ForeignKey(nameof(SalesTaxId))]
        public SalesTax? SalesTax { get; set; }


    }
}
