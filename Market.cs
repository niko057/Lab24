using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24
{
    public class Market
    {
        public Product[] Products;
       

        public Market(Product[] products)
        {
            this.Products = products;
        }

        public void InBasket(string[] selectedProducts, Customer customer)
        {
            Console.WriteLine("Stokdaki mallar:");

            foreach (var product in Products)
            {
                Console.WriteLine($"Adi:{product.Name}>>{product.inStockCount}:eded");
            }
            Console.WriteLine();

            Console.WriteLine("Secilmis mehsullarin siyahisi:");
            foreach (var productName in selectedProducts)
            {
                foreach (var product in Products)
                {
                    if (product.Name == productName)
                    {
                        if (product.AvaibleCount > 0)
                        {
                            customer.Basket.Add(product);
                            Console.WriteLine($"{product.Name} sebete elave olundu.");
                            product.AvaibleCount--;
                        }
                        else
                        {
                            Console.WriteLine($"{product.Name} - Stokda mehsul yoxdu.");
                        }
                        break;
                    }
                }
            }
            Console.WriteLine();
   
    }

        public bool AlisEtmek(string productName)
        {
            foreach (var product in Products)
            {
                if (product.Name == productName && product.AvaibleCount > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool AlisEtmeden(string productName)
        {
            foreach (var product in Products)
            {
                if (product.Name == productName && product.inStockCount > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
