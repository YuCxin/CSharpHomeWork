using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderApp
{
    //订单明细项

    public class OrderItem
    {
        public uint ItemId { get; set; }//商品id
        public Goods GoodsItem { get; set; }

        public String GoodsName { get => GoodsItem != null ? this.GoodsItem.Name : ""; }
        public uint ItemAmount { get; set; }//商品数量
        public double ItemPrice { get => GoodsItem != null ? this.GoodsItem.Price : 0.0; }//商品单价

        public OrderItem() { }
        public OrderItem(uint id, Goods goods, uint amount)
        {
            this.ItemId = id;
            this.GoodsItem = goods;
            this.ItemAmount = amount;           
        }

        public double ItemTotalPrice
        {
            get => GoodsItem == null ? 0.0 : GoodsItem.Price * ItemAmount;
        }

        //商品信息
        public override string ToString()
        {
            return $"[No.:{ItemId},goods:{GoodsName},quantity:{ItemAmount},totalPrice:{ItemTotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   GoodsName == item.GoodsName;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + ItemId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + ItemAmount.GetHashCode();
            return hashCode;
        }
    }
}
