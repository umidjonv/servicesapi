﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    interface IDefaultRepo<T>
    {
        IEnumerable<T> GetAll();

        T GetOneById(Guid id);

        void Add(T entity);

        void Edit(T entity);

        void Delete(Guid id);

        void SaveChanges();


    }
}