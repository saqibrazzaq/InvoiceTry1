﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    [Table("Service")]
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [Required, MinLength(1)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public bool ForSale { get; set; } = false;
        public bool ForPurchase { get; set; } = false;

        // Foreign keys
        public int? BusinessId { get; set; }
        [ForeignKey(nameof(BusinessId))]
        public Business? Business { get; set; }

    }
}
