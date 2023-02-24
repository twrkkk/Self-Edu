using System;
using System.Collections.Generic;

namespace Incapsulation
{
    //как правильно получить доступ к закрытой коллекции в классе
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new Basket();
            basket.ShowAllInfo();
            Console.WriteLine();
            basket.GroceryBasket.RemoveAt(0);
            basket.ShowAllInfo();
        }
    }

    class Basket
    {
        private List<Product> _groceryBasket = new List<Product>();

        public Basket()
        {
            _groceryBasket.Add(new Product("Яблоко"));
            _groceryBasket.Add(new Product("Апельсин"));
            _groceryBasket.Add(new Product("Банан"));
            _groceryBasket.Add(new Product("Груша"));
        }

        public Product GetProductByIndex(int index)
        {
            return _groceryBasket[index];
        }

        public void ShowAllInfo()
        {
            foreach (var product in _groceryBasket)
            {
                Console.WriteLine(product);
            }
        }

        class Product
        {
            public string Name { get; private set; }

            public Product(string name)
            {
                Name = name;
            }
        }

    }

}
