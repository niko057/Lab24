using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24
{
    public class Kassa
    {
        public void AlısProsesi(Customer customer, Market market)
        {
            Console.WriteLine("Alıs-verise basladiz...");

            double totalPrice = 0;
            foreach (var product in customer.Basket)
            {
                if (market.AlisEtmek(product.Name))
                {
                    totalPrice += product.Price;
                }
                else
                {
                    Console.WriteLine($"Bagislayin, '{product.Name}' movcud deyil.");
                    return;
                }
            }

            if (totalPrice > customer.CashBalance + customer.CardBalance)
            {
                Console.WriteLine("Bagislayin , odenis ucun balansinizda pul yoxdu.");
                return;
            }

            Console.WriteLine($"Umumi qiymet: {totalPrice}");

            Console.WriteLine("Odenisin bir hissesini nagd, bir hisesini kart ile etmək isteyirsizmi? (beli/xeyr)");
            string cavab = Console.ReadLine().ToLower();

            if (cavab == "beli")
            {
                Console.WriteLine("Nagd odenis meblegini daxil edin:");
                double cash = Convert.ToDouble(Console.ReadLine());
                double remaining = totalPrice - cash;

                if (cash <= customer.CashBalance && remaining <= customer.CardBalance)
                {
                    Console.WriteLine($"Nagd ile odenis etdiniz: {cash}");
                    Console.WriteLine($"Kredit karti ile odenis etdiniz: {remaining}");
                }
                else
                {
                    Console.WriteLine("Bagislayin , mebleginiz catmir.");
                    return;
                }
            }
            else if (cavab == "xeyr")
            {
                if (totalPrice <= customer.CashBalance)
                {
                    Console.WriteLine($"Nagd ile odenis edildi: {totalPrice}");
                }
                else if (totalPrice <= customer.CardBalance)
                {
                    Console.WriteLine($"Kredit karti ile odenis edildi: {totalPrice}");
                }
                else
                {
                    Console.WriteLine("Bagislayin , mebleginiz catmir.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Yanlıs cavab.");
                return;
            }

            Console.WriteLine("Alıs-veris ugurla basa catdi!");
        }
    }
}

