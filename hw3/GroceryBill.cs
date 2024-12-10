using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class GroceryBill
    {
        public Employee clerk;
        protected List<Item> items= new List<Item>();
        //update
        protected List<BillLine> lines= new List<BillLine>();       
        
        public GroceryBill() { }
        public GroceryBill(Employee clerk)
        {
            this.clerk = clerk;
        }

        public void Add(Item i) {
            items.Add(i);
        }

        public virtual double getTotal()
        {
            double total = 0; 
            foreach(Item i in items)
            {
                total += i.getPrice();
            }
            return total;
        }
        

        public virtual void printReceipt()
        {
           Console.WriteLine( items.ToString());
        }

        //Update
        public void Add(BillLine billLine)
        {
            lines.Add(billLine);
        }
        public double GetTotal()
        {
            double total = 0.0;
            foreach (var billLine in lines)
            {
                total += billLine.GetLineTotal();
            }
            return total;
        }
        public void printReceipt1()//In thông tin danh sách billLine
        {
            foreach (var billLine in lines)
            {
                Console.WriteLine(billLine);
            }
        }

    }
}
