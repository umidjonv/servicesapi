using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.DTO
{
    public class ProductReadDTO
    {
            public Guid id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public float price { get; set; }
            public float sale_price { get; set; }
            public string category_name { get; set; }
            
    }
}
