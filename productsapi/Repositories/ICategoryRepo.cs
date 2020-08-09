using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public interface ICategoryRepo : IDefaultRepo<Category>
    {

        Category GetParent(Guid id);

        IEnumerable<Category> GetChilds(Guid id);

        IEnumerable<Product> GetProducts(Guid id);

        

    }
}
