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
    //订单明细项
    public class OrderItem
    {
        public uint ItemId { get; set; }//商品id
        public string ItemName { get; set; }//商品名
        public uint ItemAmount { get; set; }//商品数量
        public double ItemPrice { get; set; }//商品单价

        public OrderItem(uint ItemId, string ItemName, uint ItemAmount, double ItemPrice)
        {
            this.ItemId = ItemId;
            this.ItemName = ItemName;
            this.ItemAmount = ItemAmount;
            this.ItemPrice = ItemPrice;
        }

        public double ItemTotalPrice
        {
            get => ItemPrice * ItemAmount;
        }

        //商品信息
        public override string ToString()
        {
            return $"[No.:{ItemId},goods:{ItemName},quantity:{ItemAmount},totalPrice:{ItemTotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   ItemName == item.ItemName &&
                   ItemId == item.ItemId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ItemName, ItemId);
        }
    }


}
