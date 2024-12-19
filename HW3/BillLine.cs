using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class BillLine
    {
        public Item item { get; set; }
        public int quantity { get; set; }

        public BillLine() { }
        public BillLine(Item item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }

        public double GetLineTotal()
        {
            if (item == null)
            {
                throw new InvalidOperationException("Item is not initialized.");
            }

            return quantity * item.getPrice();
        }


        public override string ToString()
        {
            return $"{item.getIdItem()} : {quantity}  have total price ${GetLineTotal()}";
        }
    }
}
