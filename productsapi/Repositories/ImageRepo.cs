using Microsoft.EntityFrameworkCore;
using productsapi.Data;
using productsapi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Repositories
{
    public class ImageRepo : DefaultRepo<Image>, IImageRepo
    {
        public ImageRepo(ProductContext context) : base(context)
        {
            
        }
    }
}
