using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetAll();

        Category GetOneById(Guid id);

        void Add(Category category);

        void Edit(Category category);

        void Delete(Guid id);

        Category GetParent(Guid id);

        IEnumerable<Category> GetChilds(Guid id);

        IEnumerable<Product> GetProducts(Guid id);

        void SaveChanges();

    }
}
