using System;
using System.Collections.Generic;
using System.Text;

namespace DALLibrary
{
    /*
     *      
     */
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        // Collection navigation property
        public ICollection<Product> Products { get; set; }
    }
}
