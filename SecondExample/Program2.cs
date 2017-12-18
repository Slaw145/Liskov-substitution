using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Program2
    {
        static void Main()
        {
            List<TypeProduct> typeproducts = new List<TypeProduct>();

            typeproducts.Add(new Fruit());
            typeproducts.Add(new Drink());
            typeproducts.Add(new Candys());

            foreach (TypeProducts obj in typeproducts)
            {
                if (obj is Drink)
                    break; // We do not measure the amount of water in kilograms

                obj.GetKiloQuantity();
            }
        }
    }
}
