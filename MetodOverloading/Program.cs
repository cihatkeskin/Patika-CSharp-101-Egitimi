using System;

namespace MetodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out Parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Basarili!");
                Console.WriteLine(outSayi);
            }

            else
            {
                Console.WriteLine("Basarisiz!");
            }

            Metodlar instance = new Metodlar();
            instance.Topla(4, 5, out int ToplamSonucu);
            Console.WriteLine(ToplamSonucu);


            // Metod Overloading - Aşırı Yükleme

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Cihat", " Keskin");


            // Metod İmzası
            // metodAdi + parametre sayisi + parametre tipi -> bunların üçü aynı olmamalı.
        }
    }

    class Metodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
