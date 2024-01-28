﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
      
       public ICollection<Item> Items { get; set;} = new HashSet<Item>();

    }
}
