using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Student
    {
        private string maSV;
        private string hoTen;
        private double diemTB;

        public Student(string maSV, string hoTen, double diemTB)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diemTB = diemTB;
        }
        public Student()
        {
            this.maSV = "";
            this.hoTen = "";
            this.diemTB = 0;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }

        public void GetIf()
        {
            Console.WriteLine("Ma sv: {0}\n Ho ten: {1} \n Diem: {2} \n", maSV, hoTen, diemTB);
        }
        public void Input()
        {
            Console.WriteLine("Ma SV: ");
            this.maSV = Console.ReadLine();

            Console.WriteLine("Ho ten: ");
            this.hoTen = Console.ReadLine();

            Console.WriteLine("Diem: ");
            this.diemTB = Double.Parse(Console.ReadLine());

        }
    }
}
