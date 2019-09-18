using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class FulltimeEmployee:Emloyee
    {
        public override void Xuat()
        {
            Console.WriteLine(SoHopDong);
        }
        public override string TaoHopDong()
        {
            return MaNhanVien + " + " + NgayVaoLam + "+ HDFT";
        }
    }
}
