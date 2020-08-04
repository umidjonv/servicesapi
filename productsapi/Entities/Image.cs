using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Entities
{
    public class Image
    {
        public Guid id { get; set; }
        public string path { get; set; }
        public Product product { get; set; }

}
}
