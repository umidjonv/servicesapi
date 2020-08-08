using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Entities
{
    public interface IEntity
    {
        
        public int id { get; set; }


        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        [DefaultValue(true)]
        public bool status { get; set; }
    }

  
}
