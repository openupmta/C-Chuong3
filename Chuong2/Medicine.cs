using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2
{
    class Medicine
    {
        private string medicineCode;
        private string medicineName;
        private string manufacturerName;
        private int price;
        private int quantityOnHand;
        private DateTime manufacturedDate;
        private DateTime expiryDate;
        private int batchNumber;

        
        public Medicine()
        {
            this.medicineCode = "";
            this.medicineName = "";
            this.manufacturerName = "";
            this.price = 0;
            this.quantityOnHand = 0;
            this.batchNumber = 0;
        }

        public Medicine(string medicineCode)
        {
            this.medicineCode = medicineCode;
        }

        public Medicine(string medicineCode, string medicineName, string manufacturerName, int price,int quantityOnHand, DateTime manufacturedDate, DateTime expiryDate, int batchNumber)
        {
            this.medicineCode = medicineCode;
            this.medicineName = medicineName;
            this.manufacturerName = manufacturerName;
            this.price = price;
            this.quantityOnHand = quantityOnHand;
            this.manufacturedDate = manufacturedDate;
            this.expiryDate = expiryDate;
            this.batchNumber = batchNumber;
        }

        public string MedicineCode
        {
            get { return medicineCode; }
            set { medicineCode = value; }
        }
        public string MedicineName
        {
            get { return medicineName; }
            set { medicineName = value; }
        }
        public string ManufacturerName
        {
            get { return manufacturerName; }
            set { ManufacturerName = value; }
        }
        public int Price
        {
            get { return price;  }
            set { price = value; }
        }

       
        

        public int BatchNumber { get => batchNumber; set => batchNumber = value; }
        public DateTime ManufacturedDate { get => manufacturedDate; set => manufacturedDate = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public int QuantityOnHand { get => quantityOnHand; set => quantityOnHand = value; }

        public virtual void Accept()
        {
            Console.WriteLine("Nhap ma thuoc: ");
            this.medicineCode = Console.ReadLine();
            Console.WriteLine("Ten thuoc");
            this.medicineName = Console.ReadLine();
            Console.WriteLine("Ten nha san xuat: ");
            this.manufacturerName = Console.ReadLine();
            Console.WriteLine("Don gia: ");
            this.price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ngay san xuat: ");
            string date = Console.ReadLine();
            this.manufacturedDate = DateTime.ParseExact(date, "dd/MM/yyyy", null);
            Console.WriteLine("Ngay het han: ");
            string date1 = Console.ReadLine();
            this.expiryDate = DateTime.ParseExact(date1, "dd/MM/yyyy", null);
            Console.WriteLine("So lo: ");
            this.batchNumber = Int32.Parse(Console.ReadLine());
        }
        public virtual void Print()
        {
            Console.WriteLine("Ma thuoc: {0}\nTen thuoc: {1} \nTen nha san xuat: {2}\nDon gia: {3}\nNgay san xuat: {4}\nNgay het han: {5}" +
                "\nSo lo: {6}",this.medicineCode, this.medicineName, this.manufacturerName,this.price,this.manufacturedDate,this.expiryDate,this.batchNumber);
        }
        public virtual void Print(int quantityOnHand)
        {
            Console.WriteLine("So luong tren tay: {0}", quantityOnHand);
        }
        public virtual void Print(DateTime expiryDate,DateTime manufacturedDate)
        {
            Console.WriteLine("Ten nha san xuat: {0} \n Ngay het han: {1}", expiryDate,manufacturedDate);
        }
        
    }
}
