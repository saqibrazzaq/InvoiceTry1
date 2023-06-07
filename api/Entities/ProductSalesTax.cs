using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("ProductSalesTax")]
    public class ProductSalesTax
    {
        [Key]
        public int ProductSalesTaxId { get; set; }
        
        // Foreign keys
        public int? ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product? Product { get; set; }

        public int? SalesTaxId { get; set; }
        [ForeignKey(nameof(SalesTaxId))]
        public SalesTax? SalesTax { get; set; }
    }
}
