using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class DiscountBill:GroceryBill
    {
        private bool preferred;
        private int DiscountCount;
        private double DiscountAmount;

        public DiscountBill(Employee clerk, bool preferred) : base(clerk)
        {
            this.preferred = preferred;
        }

        public override double getTotal()
        {
            double total = 0.0;
            foreach(Item i in items)
            {
                if (preferred && i.getDiscount() > 0)
                {
                    DiscountCount++;
                    DiscountAmount += i.getDiscount();
                    total += (i.getPrice() - i.getDiscount());
                }
                else
                    total += i.getPrice();
            }
            return total;
        }
        
        public int getDiscountCount()
        {
            DiscountCount = 0;
            foreach (Item i in items) {
                if (i.getDiscount() > 0)
                    DiscountCount++;
            }
            return DiscountCount;
        }

        public double getDiscountAmount() { 
            DiscountAmount = 0.0;
            foreach (Item i in items) {
                if (i.getDiscount() > 0)
                    DiscountAmount += i.getDiscount();
            }
            return DiscountAmount;
        }

        public override void printReceipt()
        {
            Console.WriteLine($"Receipt (Clerk: {clerk.Name}):");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total: ${getTotal()}");
        }
    }
}
