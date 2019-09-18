using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class SortHT : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (String.Compare(x.HoTen, y.HoTen, true) < 0)
                return -1;
            else if (String.Compare(x.HoTen, y.HoTen, true) > 0)
                return 1;
            else
                return 0;
        }
    }
}
