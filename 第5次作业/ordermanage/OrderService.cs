using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ordermanage
{    //订单服务 增删改查
    public class OrderService
    {

        private List<Order> orders;


        public OrderService()
        {
            orders = new List<Order>();
        }

        public List<Order> Orders
        {
            get => orders;
        }

        public Order GetOrder(string id)
        {
            return orders.Where(o => o.OrderId == id).FirstOrDefault();
        }

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ApplicationException($"Add Order Error: Order with id {order.OrderId} already exists!");
            orders.Add(order);
        }

        public void RemoveOrder(string Customer)
        {
            Order order = GetOrder(Customer);
            if (order != null)
            {
                orders.Remove(order);
            }
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            var query = orders
                    .Where(order => order.Items.Exists(item => item.ItemName == goodsName))
                    .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            return orders
                .Where(order => order.Customer == customerName)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        public void UpdateOrder(Order newOrder)
        {
            Order oldOrder = GetOrder(newOrder.OrderId);
            if (oldOrder == null)
                throw new ApplicationException($"Update Error：the order with id {newOrder.OrderId} does not exist!");
            orders.Remove(oldOrder);
            orders.Add(newOrder);
        }

        public void Sort()
        {
            orders.Sort();
        }

        public void Sort(Func<Order, Order, int> func)
        {
            Orders.Sort((o1, o2) => func(o1, o2));
        }      
   
    }
}

