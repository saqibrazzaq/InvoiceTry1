using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class EmployeeRes
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }

        // Foreign key
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
    }

    public class EmployeeReqEdit
    {
        [Required, MinLength(1)]
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }

        public int? DepartmentId { get; set; }
        
    }

    public class EmployeeReqSearch : PagedReq
    {

    }
}
