using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.DTO
{
    public class CategoryReadDTO
    {
        public Guid id { get; set; }
        
        public string name { get; set; }

        public string parent_name { get; set; }

    }
}
