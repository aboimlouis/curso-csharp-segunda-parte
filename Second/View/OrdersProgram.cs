using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Orders;
using Second.Entities.Enums.Orders;
using System.Globalization;
namespace Second.View
{
    class OrdersProgram
    {
        public static void Display()
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(client, os);

            Console.Write("How many items to this order? ");
            int numberOfItems = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());


                order.AddItem(new OrderItem(quantity, price, new Product(productName, price)));
            }
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
