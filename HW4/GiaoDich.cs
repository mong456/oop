using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class GiaoDich
    {
        private string ngayTH;
        public string NgayTH
        {
            get { return ngayTH; }
            set
            {
                if(value!="")
                    ngayTH = value;
            }
        }
        private string kieuGD;
        public string KieuGD
        {
            get { return kieuGD; }
            set
            {
                if(value=="nhap tien" || value=="rut tien")
                    kieuGD = value;
            }
        }
        private decimal soTien;
        public decimal SoTien
        {
            get { return soTien; }
            set
            {
                if(value>0)
                    soTien = value;
            }
        }
        public GiaoDich() { }

        public GiaoDich (string ngayTH,string kieuGD, decimal soTien)
        {
            NgayTH = ngayTH;
            KieuGD = kieuGD;
            SoTien = soTien;
        }

        public override string ToString()
        {
            return $"{NgayTH} - {KieuGD} - {SoTien}";
        }
    }
}
