using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    abstract class TypeProduct
    {
        public int QuantityLiter { get; set; }
        public abstract void GetTypeProductsCount(int quantity);
        public abstract int ReturnQuantityLiter();
    }

    class Fruit : TypeProduct
    {
        public int NumberFruit { get; set; }

        public override void GetTypeProductsCount(int quantity)
        {
            NumberFruit += quantity;
        }

        public override int ReturnQuantityLiter()
        {
            // What? The weight of fruit is not measured in liters...
        }
    }

    class Drink : TypeProduct
    {
        public int NumberDrinks { get; set; }

        public override void GetTypeProductsCount(int quantity)
        {
            NumberDrinks += quantity;
        }

        public override int ReturnQuantityLiter()
        {
            return QuantityLiter;
        }
    }
}
