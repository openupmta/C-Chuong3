using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2
{
    class Sales : Medicine
    {
        private int quantitySold;
        private int plannedSales;
        private int actualSales;
        private string region;

        public Sales(string medicineCode, int quantitySold, int plannedSales, int actualSales, string region) : base(medicineCode)
        {
            this.quantitySold = quantitySold;
            this.plannedSales = plannedSales;
            this.actualSales = actualSales;
            this.region = region;
        }
        public Sales()
        {
            this.quantitySold = 0;
            this.plannedSales = 0;
            this.actualSales = 0;
            this.region = "";
        }

        public int QuantitySold { get => quantitySold; set => quantitySold = value; }
        public int PlannedSales { get => plannedSales; set => plannedSales = value; }
        public int ActualSales { get => actualSales; set => actualSales = value; }
        public string Region { get => region; set => region = value; }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("So luong ban: ");
            this.quantitySold = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ban ke hoach: ");
            this.plannedSales = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ban hang thuc te: ");
            this.actualSales = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Khu vuc : ");
            this.region = Console.ReadLine();
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Ma thuoc : {0} \n", MedicineCode);
            Console.WriteLine("\nSo luong ban: {0} \nBan ke hoach: {1}\nBan thuc te: {2}\nKhu vuc: {3}\n",
                this.quantitySold, this.plannedSales, this.actualSales, this.region);
        }
        public virtual void Display()
        {
            Console.WriteLine("Ma thuoc : {0} \n", MedicineCode);
            Console.WriteLine("\nSo luong ban: {0} \nBan ke hoach: {1}\nBan thuc te: {2}\nKhu vuc: {3}\n",
                this.quantitySold, this.plannedSales, this.actualSales, this.region);
        } 
        public virtual void Display(string actualSales, string plannedSales)
        {
            Console.WriteLine("Ban hang thuc te: {0}\nBan hang theo ke hoach: {1}", actualSales, plannedSales);

        }
        
    }
}
