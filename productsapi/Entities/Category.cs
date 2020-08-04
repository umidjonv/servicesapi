using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Models
{
    public class Category
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }

        public IEnumerable<Category> childs;

        public Category parent;

    }
}
