using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class StateRes
    {
        public int StateId { get; set; }
        public string? Name { get; set; }

        // Foreign keys
        public int? CountryId { get; set; }
        public Country? Country { get; set; }
    }

    public class StateReqEdit
    {
        [Required, MinLength(3)]
        public string? Name { get; set; }

        // Foreign keys
        public int? CountryId { get; set; }
        
    }

    public class StateReqSearch : PagedReq
    {

    }
}
