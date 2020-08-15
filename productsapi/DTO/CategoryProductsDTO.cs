using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.DTO
{
    public class CategoryProductsDTO
    {
        public Guid id { get; set; }
        
        public IEnumerable<Product> products { get; set; }

    }
}
