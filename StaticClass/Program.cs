using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");

            Calisan calisan = new Calisan("Cihat", "Keskin", "Yazılım");

            Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");
            
            Console.WriteLine($"Toplama işlemi sonucu: {Islemler.Topla(100, 200)}");
            Console.WriteLine($"Çıkarma işlemi sonucu: {Islemler.Cikar(400, 50)}");
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;

        private string Soyisim;

        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            Isim = isim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
