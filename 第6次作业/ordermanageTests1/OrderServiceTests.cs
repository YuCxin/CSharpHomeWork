using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordermanage;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using ordermanage;
using System.IO;
using System.Linq;

namespace ordermanage.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService service = new OrderService();
        OrderItem pen = new OrderItem(001, "pen", 5, 2.5);
        OrderItem eraser = new OrderItem(002, "eraser", 2, 1);
        OrderItem ruler = new OrderItem(003, "ruler", 1, 5);

            

        [TestInitialize()]
        public void init()
        {
            Order order1 = new Order("Xindy", new List<OrderItem> { pen, eraser, ruler });
            Order order2 = new Order("Rosa", new List<OrderItem> { pen, ruler });
            //Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });
            service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);
            //service.AddOrder(order3);
        }
        
        [TestInitialize]
        public void Test()
        {
            service = new OrderService();
            //xmlSerializer = new XmlSerializer(typeof(HashSet<Order>));
        }

        [TestMethod()]
        public void OrderServiceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Order order3 = new Order();
            service.AddOrder(order3);
            Assert.AreEqual(3, service.Orders.Count);
            CollectionAssert.Contains(service.Orders, order3);
            Order order1 = new Order("Lucy", new List<OrderItem> { pen });
            int i = service.Orders.Count + 1;
            service.AddOrder(order1);
            int j = service.Orders.Count;
            Assert.IsTrue(i == j);
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            Order order1 = new Order("Lucy", new List<OrderItem> { pen });
            service.AddOrder(order1);
            service.RemoveOrder(order1.OrderId);
            int i = service.Orders.Count;
            Assert.IsTrue(i == 0);
        }

        [TestMethod()]
        public void QueryOrdersByGoodsNameTest()
        {
         
            Assert.AreEqual(2, service.QueryOrdersByGoodsName("pen").Count);
            Assert.AreEqual(2, service.QueryOrdersByGoodsName("ruler").Count);
            Assert.AreEqual(3, service.QueryOrdersByGoodsName("eraser").Count);            
        }

        [TestMethod()]
        public void QueryOrdersByCustomerNameTest()
        {
            Order order1 = new Order("Lucy", new List<OrderItem> { pen });
            Order order2 = new Order("Lucy", new List<OrderItem> { pen });
            HashSet<Order> orders1 = new HashSet<Order>();
            orders1.Add(order1);
            orders1.Add(order2);
            service.AddOrder(order1);
            service.AddOrder(order2);
            Assert.IsTrue(service.QueryOrdersByCustomerName("Lucy").Contains(order1) && service.QueryOrdersByCustomerName("Lucy").Contains(order2));
        }

        

        [TestMethod()]
        public void ExportTest()
        {
            String file = "temp.xml";
            service.Export(file);
            Assert.IsTrue(File.Exists(file));
            List<String> expectLines = File.ReadLines("expectedOrders.xml").ToList();
            List<String> outputLines = File.ReadLines(file).ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService os = new OrderService();
            os.Import("./expectedOrders.xml");
            Assert.AreEqual(3, os.Orders.Count);

            os.Import("./newOrders.xml");
            Assert.AreEqual(5, os.Orders.Count);
        }
    }
}