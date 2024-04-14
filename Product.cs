using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int AvaibleCount { get; set; }
        public int inStockCount { get; set; }

        public Product(string name,double price,int avaiblecount,int instockcount)
        {
            Name= name;
            Price= price;
            AvaibleCount= avaiblecount;
            inStockCount= instockcount;
        }
    }
}
