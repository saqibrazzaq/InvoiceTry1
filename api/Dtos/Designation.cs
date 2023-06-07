using api.Paging;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class DesignationRes
    {
        public int DesignationId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class DesignationReqEdit
    {
        [Required, MinLength(2)]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class DesignationReqSearch : PagedReq
    {

    }
}
