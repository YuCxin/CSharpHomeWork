using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace ordermanage
{
    public class Order
    {
        private List<OrderItem> items;  

        public string OrderId { get; set; }

        public string Customer { get; set; }//客户名

        public DateTime CreateTime { get; set; }//时间

        public Order() {
            items = new List<OrderItem>(); CreateTime = DateTime.Now; 
        }

        public Order(string customer, List<OrderItem> items)
        {
            Random rd = new Random();
            this.OrderId = DateTime.Now.ToString("yyyyMMddHHmmss") + rd.Next(1, 20);
            this.Customer = customer;
            this.items = (items == null) ? new List<OrderItem>() : items;
        }

        public List<OrderItem> Items
        {
            get { return items; }
        }

        public double TotalPrice
        {
            get => items.Sum(item => item.ItemTotalPrice);
        }

        //增加商品
        public void AddItem(OrderItem orderItem)
        {
            if (Items.Contains(orderItem))
                throw new ApplicationException($"orderItem-{orderItem} is already existed!");
            Items.Add(orderItem);
        }      

        //删除某个商品    
        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Id:{OrderId}, customer:{Customer},orderTime:{this.CreateTime.ToShortDateString()},totalPrice：{TotalPrice}");
            items.ForEach(od => strBuilder.Append("\n\t" + od));
            return strBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            var hashCode = -531220479;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + CreateTime.GetHashCode();
            return hashCode;
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderId.CompareTo(other.OrderId);
        }

    }
}
