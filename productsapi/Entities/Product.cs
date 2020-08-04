using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Models
{
    public class Product
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(500)]
        public string description { get; set; }

        public float price { get; set; }
        public float sale_price { get; set; }
        [Required]
        public Category category { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool status { get; set; }

    }
}
