using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class CountryRes
    {
        public int CountryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }

        // Child tables
        public IList<State>? States { get; set; }
    }

    public class CountryReqEdit
    {
        [Required, MinLength(3)]
        public string? Name { get; set; }
        [Required, MinLength(3), MaxLength(3)]
        public string? Code { get; set; }

    }

    public class CountryReqSearch : PagedReq
    {

    }
}
