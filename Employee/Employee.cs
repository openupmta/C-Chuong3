using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Emloyee
    {
        private string maNhanVien;
        private string hoTen;
        private string soHopDong;
        private DateTime ngayVaoLam;

        public Emloyee(string maNhanVien, string hoTen, string soHopDong, DateTime ngayVaoLam)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.soHopDong = soHopDong;
            this.ngayVaoLam = ngayVaoLam;
        }
        public Emloyee()
        {
            this.maNhanVien = "";
            this.hoTen = "";
            this.soHopDong = "";
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoHopDong { get => soHopDong; set => soHopDong = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ma nhan vien: ");
            this.maNhanVien = Console.ReadLine();
            Console.WriteLine("Ho ten: ");
            this.hoTen = Console.ReadLine();
            Console.WriteLine("Ngay vao lam: ");
            string input = Console.ReadLine();
            this.ngayVaoLam = DateTime.ParseExact(input, "dd/MM/yyyy", null);
            //while(!DateTime.TryParse(input,out ngayVaoLam))
            //{
            //    Console.WriteLine("Ngay vao lam: ");
            //    input = Console.ReadLine();
            //}
            this.soHopDong = TaoHopDong();
        }
        public virtual void Xuat()
        {
            Console.WriteLine(soHopDong);
        }
        public virtual string TaoHopDong()
        {
            return this.maNhanVien + " + " + this.ngayVaoLam + "+ HD";
        }
    }
}
