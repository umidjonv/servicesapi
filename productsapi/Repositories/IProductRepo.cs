using productsapi.Models;
using productsapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi
{
    public interface IProductRepo:IDefaultRepo<Product>
    {
        

    }
}
