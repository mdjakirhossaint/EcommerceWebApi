﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
   public class MostView
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
