using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class TaiKhoan
    {
        private string soHieuTK;
        public string SoHieuTK{
            get { return soHieuTK; }
            set
            {
                if(value !="")
                    soHieuTK = value;
            }
        }

        private string cmnd;
        public string CMND
        {
            get { return cmnd; }
            set
            {
                if(value.Length==9)
                    cmnd = value;
            }
        }
        private string tenChuTK;
        public string TenCTK
        {
            get { return tenChuTK; }
            set
            {
                if (value != "")
                    tenChuTK = value;
            }
        }
        private decimal soTien;
        public decimal SoTien
        {
            get { return soTien; }
            set { 
                if(value>0)
                    soTien = value;
                    }
        }
        private decimal laiSuat;
        public decimal LaiSuat
        {
            get { return laiSuat; }
            set { 
                if(value>0)
                    laiSuat = value;
                    }
        }
        public List<GiaoDich> giaoDiches;
        public TaiKhoan() { }
        public TaiKhoan(string soHieuTK, string cmnd, string tenChuTK, decimal soTien, decimal laiSuat)
        {
            SoHieuTK = soHieuTK;
            CMND = cmnd;
            TenCTK = tenChuTK;
            SoTien = soTien;
            LaiSuat = laiSuat;
            giaoDiches= new List<GiaoDich>();
        }

        //Phương thức gửi tiền
        public void GiaoDTK(decimal sotien,string kieugd)
        {
            if (soTien > 0 && kieugd=="nhap tien")
            {
                GiaoDich gd=new GiaoDich(DateTime.Now.ToString(),kieugd,sotien);
                SoTien += sotien;
                giaoDiches.Add(gd);
            }
            else if(sotien>0 && kieugd=="rut tien")
            {
                SoTien -= sotien;
                giaoDiches.Add(new GiaoDich(DateTime.Now.ToString(), kieugd, SoTien));
            }
            else 
                Console.WriteLine("So tien khong am.");               
        }

        //Tính lãi suất
        public void TinhLaiSuat()
        {
            decimal lai = SoTien * LaiSuat;
            SoTien += lai;
            giaoDiches.Add(new GiaoDich(DateTime.Now.ToString(), "Cong lai suat", lai));
        }

        //Hiển thị thông tin tài khoản
        public override string ToString()
        {
            return $"{SoHieuTK} - {CMND} - {SoTien} - {LaiSuat}";
        }
    }
}
