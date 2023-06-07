using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos
{
    public class BillItemRes
    {
        public int BillItemId { get; set; }

        public int? BillId { get; set; }
        public Bill? Bill { get; set; }

        public int? ServiceId { get; set; }
        public Service? Service { get; set; }

        public string? Description { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
    }

    public class BillItemReqEdit
    {
        public int? BillId { get; set; }
        public int? ServiceId { get; set; }
        public string? Description { get; set; }
        public double Quantity { get; set; } = 1;
        public double Price { get; set; } = 0;
    }

    public class BillItemReqSearch : PagedReq
    {

    }
}
