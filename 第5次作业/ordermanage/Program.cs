using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ordermanage
{
    class Program
    {
        public static void Main()
        {
            try
            {
                OrderItem pen = new OrderItem(001, "pen", 5, 2.5);
                OrderItem eraser = new OrderItem(002, "eraser",2, 1);
                OrderItem ruler = new OrderItem(3, "ruler", 1, 5);

                Order order1 = new Order("Xindy", new List<OrderItem> { pen, eraser, ruler});
                Order order2 = new Order("Rosa", new List<OrderItem> { pen,ruler });

                OrderService os = new OrderService();
                os.AddOrder(order1);
                os.AddOrder(order2);

                Console.WriteLine("GetAllOrders");
                List<Order> orders = os.Orders;
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

                os.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));
                Console.WriteLine("GetAllOrders After sort");
                orders = os.Orders;
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

                Console.WriteLine("GetOrdersByCustomerName:'Customer2'");
                orders = os.QueryOrdersByCustomerName("Customer2");
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

                Console.WriteLine("GetOrdersByGoodsName:'apple'");
                orders = os.QueryOrdersByGoodsName("apple");
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

                Console.WriteLine("Remove order(Customer:Rosa) and qurey all");
                os.RemoveOrder("Rosa");
                orders.ForEach(o => Console.WriteLine(o));
                Console.WriteLine("");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }
        
    }
}

