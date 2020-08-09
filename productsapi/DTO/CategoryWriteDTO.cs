using productsapi.Helpers;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.DTO
{
    public class CategoryWriteDTO
    {
        public string name { get; set; }
        
        public Guid parent_id { get; set; }

        public Category parent { get; set; }

    }
}
