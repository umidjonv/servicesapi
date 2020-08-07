using Microsoft.EntityFrameworkCore.ChangeTracking;
using productsapi.Data;
using productsapi.Entities;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        ProductContext _context;

        public CategoryRepo(ProductContext context)
        {
            _context = context;
                        
        }


        public void Add(Category category)
        {
            _context.Category.Add(category);
        }

        
        public void Delete(Guid id)
        {
            _context.Category.FirstOrDefault<Category>(x => x.id == id).status = false;


        }

        public void Edit(Category category)
        {
            _context.Category.Update(category);
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public IEnumerable<Category> GetChilds(Guid id)
        {
            return _context.Category.Where(x => x.id == id).ToList();
        }

        public Category GetOneById(Guid id)
        {
            return _context.Category.FirstOrDefault(x => x.id == id);
        }

        public Category GetParent(Guid id)
        {
            return _context.Category.FirstOrDefault(x => x.id == id);
        }

        public IEnumerable<Product> GetProducts(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

    
}
