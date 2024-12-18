using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class NganHang
    {
        public List<TaiKhoan> tks = new List<TaiKhoan>();

        public NganHang()
        {

        }
        public NganHang(TaiKhoan tk)
        {
            tks.Add(tk);
        }

        //Mở tài khoản
        public void MoTK(TaiKhoan tk)
        {
            if (!tks.Contains(tk))
            {
                tks.Add(tk);
            }
            else
                Console.WriteLine("Khong the mo tk");
        }

        //Phương thức nạp tiền 
        public void NapTien(decimal st,string cm)
        {
            foreach (TaiKhoan tk in tks) {
                if (tk.CMND == cm)
                {
                    tk.GiaoDTK(st, "nap tien");
                }
                else
                    Console.WriteLine("Tai khoan khong ton tai");
            }
           
        }

        //Hiển thị tài khoản
        public void HienThi()
        {
            foreach(TaiKhoan tk in tks)
            {
                Console.WriteLine(tk.ToString());
            }
        }
    }
}
