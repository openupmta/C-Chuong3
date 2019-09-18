using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            List<Student> list = new List<Student>();
            for(int i = 0; i< 4; i++)
            {
                s.Input();
                list.Add(new Student(s.MaSV, s.HoTen, s.DiemTB));
            }
            //SortHT ht = new SortHT();
            //list.Sort(ht);
            SortDHT ht = new SortDHT();
            list.Sort(ht);

            foreach (Student s1 in list)
            {
                s1.GetIf();
            }
        }
    }
}
