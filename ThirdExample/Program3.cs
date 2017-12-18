using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Product
    {
        public virtual void PriceProduct(double price)
        {
            Console.WriteLine("This product costs: " + price + " PLN");
        }
    }

    class ElectronicsProduct : Product
    {
        public override void PriceProduct(double price)
        {
            base.PriceProduct(price);
            Console.WriteLine("Price description of only electronic product");
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string getProduct = Console.ReadLine();

                if (getProduct == "bread")
                {
                    Product product = new Product();
                    product.PriceProduct(2.4);
                }
                else if (getProduct == "iphone7")
                {
                    ElectronicsProduct electronicsproduct = new ElectronicsProduct();
                    electronicsproduct.PriceProduct(3324.234);
                }
            }

            Console.ReadKey();
        }
    }
}
