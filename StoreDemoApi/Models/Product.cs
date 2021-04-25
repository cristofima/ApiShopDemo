using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace StoreDemoApi.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Range(0.01, 300)]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public bool Enabled { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
        public string Description { get; set; }
    }
}
