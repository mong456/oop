using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaiKhoan tk1 = new TaiKhoan("1", "123456789","tk1", 3000, 0.5m);
            TaiKhoan tk2 = new TaiKhoan("2", "123456789", "tk2", 3000, 0.7m);
            tk1.GiaoDTK(1000,"rut tien");

            NganHang nh = new NganHang(tk1);
            nh.MoTK(tk2);
            nh.HienThi();

           
        }
    }
}
