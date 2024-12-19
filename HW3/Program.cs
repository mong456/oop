using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo nhân viên và hóa đơn
            Employee clerk = new Employee();
            clerk.Name = "Lai";
            DiscountBill bill = new DiscountBill(clerk, true);

            // Thêm sản phẩm
            Item item1 = new Item("It1", 1.35, 0.25);
            Item item4 = new Item("It1", 1.35, 0.25);
            Item item2 = new Item("It2", 2.50, 0.5);
            Item item3 = new Item("It3", 3.00, 0.0);

            bill.Add(item1);
            bill.Add(item2);
            bill.Add(item3);
            bill.Add(item4);

            // In hóa đơn
            bill.printReceipt();
            Console.WriteLine("Total discount item: " +bill.getDiscountCount());//Số lượng hàng chiếu khấu
            Console.WriteLine("Total discount amount: "+bill.getDiscountAmount());//Tổng giá trị chiết khấu
            Console.WriteLine();

            //Phần update với billLine
            BillLine line = new BillLine(item1,3);//tạo 1 billLine
            BillLine line1 = new BillLine(item2, 2);//Tạo billLine2
            Console.WriteLine("Price of billLine 1: "+line.GetLineTotal());//IN ra giá billLine 1
            GroceryBill gc = new GroceryBill();
            gc.Add(line);//Thêm billLine vào GroceryBill
            gc.Add(line1);//Thêm billLine 2 vào GroceryBill
            gc.printReceipt1();//Danh sách billLine
            Console.WriteLine("Total GroceryBill: "+gc.GetTotal());//Tổng GroceryBill

        }
    }
}
