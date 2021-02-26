using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Product;

namespace Second.View
{
    class ProductProgram
    {
        public static void Display()
        {
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();
            for(int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} product data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                string productType = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (productType == "c")
                {
                    products.Add(new Product(name, price));
                }
                else if (productType == "i")
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (productType == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.WriteLine("Invalid product type, product not added");
                }
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
