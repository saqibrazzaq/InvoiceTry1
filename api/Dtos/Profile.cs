using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class ProfileRes
    {
        public int ProfileId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Child tables
        public IList<Business>? Businesses { get; set; }
    }

    public class ProfileReqEdit
    {
        [Required, MinLength(1)]
        public string? FirstName { get; set; }
        [Required, MinLength(1)]
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;

    }

    public class ProfileReqSearch : PagedReq
    {

    }
}
