using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(3, 3);
            Matrix m2 = new Matrix(3, 3);
            Matrix m3;

            Console.WriteLine($"Nhap ma tran A [{m1.NumRow}x{m1.NumCol}]");
            m1.Creat("a");
            
            Console.WriteLine($"Nhap ma tran B [{m2.NumRow}x{m2.NumCol}]");
            m2.Creat("b");

            Console.WriteLine("\nMa tran A:");
            m1.Display();
            Console.WriteLine("\nMa tran B:");
            m2.Display();

            if (m1.NumRow == m2.NumRow && m1.NumCol == m2.NumCol)
            {
                Console.WriteLine("\nTong 2 ma tran: C = A + B");
                m3 = m1 + m2;
                m3.Display();

                Console.WriteLine("\nHieu 2 ma tran: D = A - B");
                m3 = m1 - m2;
                m3.Display();
            }
            else
            {
                Console.WriteLine("\nTong 2 ma tran khong tinh duoc!!!");
                Console.WriteLine("\nHieu 2 ma tran khong tinh duoc!!!");
            }

            if (m1.NumCol == m2.NumRow)
            {
                Console.WriteLine("\nTich 2 ma tran: E = A x B");
                m3 = m1 * m2;
                m3.Display();
            }
            else
                Console.WriteLine("\nTich 2 ma tran khong tinh duoc!!!");
        
        }
    }
}
