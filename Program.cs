namespace Lab24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Alma", 1.5, 10, 60);
            Product product2 = new Product("Banan", 3.5, 30, 90);
            Product product3 = new Product("Heyva", 2.7, 15, 50);
            Product product4 = new Product("Uzum", 4.8, 6, 40);
            Product product5 = new Product("Ciyelek", 6.8, 4, 80);

            Market market = new Market(new Product[] { product1, product2, product3, product4, product5 });

            Customer customer = new Customer
            {
                Name = "Nicat",
                SurName = "Namazov",
                payment = Payment.Cash,
                CashBalance = 250,
                CardBalance = 500,

            };
            while (true)
            {
                Console.WriteLine("Marketden alis veris etmek isteyirsizmi..Beli/Xeyr");

                string pay = Console.ReadLine().ToLower();
                if (pay == "beli")
                {
                    customer.Basket.Add(product1);
                    customer.Basket.Add(product2);
                    customer.Basket.Add(product3);
                    customer.Basket.Add(product4);
                    customer.Basket.Add(product5);

                    Kassa kassa = new Kassa();
                    kassa.AlısProsesi(customer, market);

                    string[] selectedProducts = { "Mehsul 1", "Mehsul 2", "Mehsul 3" };


                    market.InBasket(selectedProducts, customer);


                    Console.WriteLine("MUsterinin sebetindeki mehsullar:");
                    foreach (var item in customer.Basket)
                    {
                        Console.WriteLine($"Adi:{item.Name}>>Qiymeti:{item.Price} AZN");
                    }

                }
                else if (pay == "xeyr")
                {

                    market.AlisEtmeden("Nicat Namazov");
                    Console.WriteLine("Marketden cixdiniz..");
                   
                    break;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa 'Beli' ve yaxud 'Xeyr' secin");
                }
            }




        }

    }
}