using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi
{
    interface IProductRepo
    {
        IEnumerable<Product> getAll();

        Product getOneByID();

        Guid add(Product product);

        bool edit(Guid id);

        bool delete(Guid id);

        Category getCategory(Guid id);



    }
}
