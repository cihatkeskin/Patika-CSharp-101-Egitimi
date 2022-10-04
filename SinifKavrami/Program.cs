using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //      {
            //      // Metot Komutları
            //      }
            // }        

            // Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Cihat";
            calisan1.Soyad = "Keskin";
            calisan1.No = 12345678;
            calisan1.Departman = "Yazılım";
            calisan1.CalisanBilgileri();

            Console.WriteLine();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ayşe";
            calisan2.Soyad = "Kara";
            calisan2.No = 14395276;
            calisan2.Departman = "İnsan Kaynakları";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Deparmanı: {0}", Departman);
        }
    }
}
