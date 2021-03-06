﻿using System.Collections.Generic;

namespace WingtipToys.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; private set; }
    }
}
