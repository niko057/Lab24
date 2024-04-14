using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24
{
    public class Customer
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public  Payment payment;
        public double CashBalance { get; set; }
        public double CardBalance { get; set; }
        public List<Product> Basket { get; } = new List<Product>();

        public Customer()
        {

        }

      

    }
}
