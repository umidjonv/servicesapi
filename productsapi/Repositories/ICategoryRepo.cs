using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> getAll();

        Category getOneById(Guid id);

        Guid add(Category category);

        bool edit(Guid id);

        bool delete(Guid id);

        Category getParent(Guid id);

        IEnumerable<Category> getChilds(Guid id);

        IEnumerable<Product> getProducts(Guid id);


    }
}
