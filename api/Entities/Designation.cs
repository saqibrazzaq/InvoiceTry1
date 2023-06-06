using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("Designation")]
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }
        [Required, MinLength(2)]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
