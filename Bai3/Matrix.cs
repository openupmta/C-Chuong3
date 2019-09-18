using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Matrix
    {
        private int numRow;
        private int numCol;
        private int[,] matrix;
        
        public int NumRow { get => numRow; set => numRow = value; }
        public int NumCol { get => numCol; set => numCol = value; }

        public Matrix()
        {
            NumRow = 0;
            NumCol = 0;
            matrix = new int[0, 0];
        }
        public Matrix(int numrow, int numcol)
        {
            NumRow = numrow;
            NumCol = numcol;
            matrix = new int[numrow, numcol];
        }

        // Indexer -------------------------
        public int this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }
            set
            {
                matrix[x, y] = value;
            }
        }
        // ----------------------------------

        public void Creat(string element)
        {
            for (int i = 0; i < NumRow; i++)
            {
                for (int j = 0; j < NumCol; j++)
                {
                    Console.Write($"  {element}[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < NumRow; i++)
            {
                for (int j = 0; j < NumCol; j++)
                {
                    Console.Write("  " + matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix m = new Matrix(m1.NumRow, m1.NumCol);
            for (int i = 0; i < m1.NumRow; i++)
            {
                for (int j = 0; j < m1.NumCol; j++)
                {
                    m[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return m;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix m = new Matrix(m1.NumRow, m1.NumCol);
            for (int i = 0; i < m1.NumRow; i++)
            {
                for (int j = 0; j < m1.NumCol; j++)
                {
                    m[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return m;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix m = new Matrix(m1.NumRow, m2.NumCol);
            for (int i = 0; i < m.NumRow; i++)
            {
                for (int j = 0; j < m.NumCol; j++)
                {
                    m[i, j] = 0;
                    for (int k = 0; k < m1.NumCol; k++)
                    {
                        m[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return m;
        }
    }
}
