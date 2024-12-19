using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Item
    {
        private string itemId;
        private double price;
        private double discount;

        public Item() { }
        public Item(string itemId, double price, double discount)
        {
            this.itemId = itemId;
            this.price = price;
            this.discount = discount;
        }

        public double getPrice()
        {
            return price;
        }

        public double getDiscount() { 
            return discount;
        }

        public string getIdItem()
        {
            return itemId;
        }
        public override string ToString() {
            return string.Format($"Ma sp: {itemId} - Gia: {price} - Chieu khau: {discount}");
        }
    }
}
