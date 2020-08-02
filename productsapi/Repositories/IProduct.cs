using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi
{
    interface IProduct
    {
        List<Product> getAll();

        Product getOneByID();

        Guid addNew(Product product);
        
    }
}
