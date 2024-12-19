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
            if (DuplicateID(i.getIdItem()) != true)
                items.Add(i);
            else
                Console.WriteLine($"Exist item {i.getIdItem()} in list");
        }
        public bool DuplicateID(string id)
        {
            bool flag=false;
            foreach (Item i in items) {
                if (i.getIdItem() == id.Trim())
                    flag = true;break;
            }
            return flag;
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
           Console.WriteLine(items.ToString());
        }

        //Update
        public void Add(BillLine billLine)
        {
            // Duyệt qua từng phần tử trong danh sách lines để kiểm tra xem item đã có chưa
            foreach (var existingBillLine in lines)
            {
                if (existingBillLine.item.Equals(billLine.item))
                {
                    // Nếu đã có item trong danh sách, tăng số lượng
                    existingBillLine.quantity += billLine.quantity;
                    return; // Dừng lại vì đã tìm thấy item và cập nhật số lượng
                }
            }

            // Nếu không tìm thấy item trong danh sách, thêm billLine mới vào
            lines.Add(billLine);
        }


        //Lấy tổng trong billLine
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
