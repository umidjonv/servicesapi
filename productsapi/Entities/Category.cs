using productsapi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Models
{
    [Table("category")]
    public class Category:IBaseEntity
    {

        public Guid id { get; set; }

        [Required]
        [MaxLength(100)]
        public string name { get; set; }

        public Category parent { get; set; }
        
        public IEnumerable<Category> childs { get; set; }

        public bool status { get; set; }

        public IEnumerable<Product> products { get; set; }
        

    }
}
