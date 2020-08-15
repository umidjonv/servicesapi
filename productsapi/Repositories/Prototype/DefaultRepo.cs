using Microsoft.EntityFrameworkCore;
using productsapi.Data;
using productsapi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public abstract class DefaultRepo<T> : IDefaultRepo<T> where T : class
    {
        ProductContext _context;
        public DbSet<T> _property { get; set; }
        public DefaultRepo(ProductContext context)
        {
            _context = context;
            _property = _context.Set<T>();
            
        }
            
        

        public void Add(T entity)
        {
            _property.Add(entity);
        }

        public void Delete(Guid id)
        {
            IBaseEntity entity = (IBaseEntity)_property.FirstOrDefault(x => ((IBaseEntity)x).id == id);
            entity.status = false;
        }

        public void Edit(T entity)
        {
            _property.Update(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _property.ToList();
        }

        public T GetOneById(Guid id)
        {
            return (T)_property.FirstOrDefault(x => ((IBaseEntity)x).id == id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

    }
}
