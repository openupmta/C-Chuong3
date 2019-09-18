using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Emloyee e = new Emloyee();
            //e.Nhap();
            //e.Xuat();

            ParttimeEmployee p = new ParttimeEmployee();
            p.Nhap();
            p.Xuat();
            p.TaoHopDong();

        }
    }
}
