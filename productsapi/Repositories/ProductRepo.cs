using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public class ProductRepo : IProductRepo
    {
        public List<Product> getAll()
        {
            throw new NotImplementedException();
        }

        public Product getOneByID()
        {
            throw new NotImplementedException();
        }

        public int addNew(Product product) 
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IProductRepo.getAll()
        {
            throw new NotImplementedException();
        }

        Guid IProductRepo.addNew(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
