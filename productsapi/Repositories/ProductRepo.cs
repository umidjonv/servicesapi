using productsapi.Data;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public class ProductRepo : IProductRepo
    {
        ProductContext _context;

        public ProductRepo(ProductContext context)
        {
            _context = context;            
        }

        public Product getOneByID(Guid id)
        {
            return _context.Product.FirstOrDefault(x => x.id == id);
        }

        
        public IEnumerable<Product> GetAll()
        {
            return _context.Product.ToList();
        }

        public Product GetOneById(Guid id)
        {
            return _context.Product.FirstOrDefault(x => x.id == id);
        }

        public void Add(Product entity)
        {
            _context.Product.Add(entity);
        }

        public void Edit(Product entity)
        {
            _context.Update(entity);
        }

        public void Delete(Guid id)
        {
            _context.Product.FirstOrDefault(x => x.id == id).status = false;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
