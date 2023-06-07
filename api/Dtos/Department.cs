using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class DepartmentRes
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        // Foreign key
        public int? BusinessId { get; set; }
        public Business? Business { get; set; }
    }

    public class DepartmentReqEdit
    {
        [Required, MinLength(2)]
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int? BusinessId { get; set; }
        
    }

    public class DepartmentReqSearch : PagedReq
    {

    }
}
