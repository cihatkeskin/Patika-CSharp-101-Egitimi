using System;

namespace KurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Cihat", "Keskin", 12345678, "Yazılım");
            calisan1.CalisanBilgileri();

            Console.WriteLine();

            Calisan calisan2 = new Calisan("Ayşe", "Kara");
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        string Ad;

        string Soyad;

        int No;

        string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışanın Adı: {Ad}");
            Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
            Console.WriteLine($"Çalışanın Numarası: {No}");
            Console.WriteLine($"Çalışanın Departmanı: {Departman}");
        }
    }
}
