﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entities
{
    public class Item
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
