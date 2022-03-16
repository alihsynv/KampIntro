using System;

namespace E_ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Lenovo";
            product1.ProductPrice = 2500;

            Product product2 = new Product();
            product2.ProductName = "HP";
            product2.ProductPrice = 2200;

            Product product3 = new Product();
            product3.ProductName = "HUAWEI";
            product3.ProductPrice = 3100;

            Product[] products = new Product[] { product1, product2, product3 };
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + ": " + product.ProductPrice);
            }
        }

        class Product
        {
            public string ProductName { get; set; }
            public int ProductPrice { get; set; }
        }
    }
}
