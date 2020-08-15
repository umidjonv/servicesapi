﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Entities
{
    public interface IBaseEntity
    {
        public Guid id { get; set; }
        public bool status { get; set; }
    }
}
