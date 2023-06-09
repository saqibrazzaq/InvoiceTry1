﻿using api.Entities;
using api.Paging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class ProductRes
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public bool ForSale { get; set; }
        public bool ForPurchase { get; set; }

        // Foreign keys
        public int? BusinessId { get; set; }
        public Business? Business { get; set; }
    }

    public class ProductReqEdit
    {
        public int ProductId { get; set; }
        [Required, MinLength(1)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public bool ForSale { get; set; } = false;
        public bool ForPurchase { get; set; } = false;

        public int? BusinessId { get; set; }
        
    }

    public class ProductReqSearch : PagedReq
    {

    }
}
