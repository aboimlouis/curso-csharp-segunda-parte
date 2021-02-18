using System;
using System.Collections.Generic;
using System.Text;
using Second.Entities.Enums.Orders;

namespace Second.Entities.Orders
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
            Moment = DateTime.Now;
        }

        public Order(Client client, OrderStatus satus)
        {
            Moment = DateTime.Now;
            this.Status = satus;
            this.Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += (item.Price * item.Quantity);
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items: ");
            foreach (OrderItem orderItem in Items)
            {
                sb.Append(orderItem.ToString());
            }
            sb.AppendLine(Total().ToString("F2"));
            return sb.ToString();
        }
    }
}
