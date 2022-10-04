using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            // her iki grubun kendi içerisinde ortalamalarını alan,
            // bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
            // (Array sınıfını kullanarak yazınız.)

            int[] sayilar = new int[20];
            int[] enBuyuk = new int[3];
            int[] enKucuk = new int[3];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i+1}. sayıyı giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sayilar);
            for (int i = 0; i < 3; i++)
            {
                enKucuk[i] = sayilar[i];
            }

            Array.Reverse(sayilar);
            for (int i = 0; i < 3; i++)
            {
                enBuyuk[i] = sayilar[i];
            }

            int maxToplam = 0;
            Console.WriteLine("\nEn Büyük 3 Sayı: ");
            foreach (var item in enBuyuk)
            {
                maxToplam += item;
                Console.WriteLine(item);
            }
            int maxOrt = maxToplam / enBuyuk.Length;
            Console.WriteLine("Ortalaması: " + maxOrt);

            int minToplam = 0;
            Console.WriteLine("\nEn Küçük 3 Sayı: ");
            foreach (var item in enKucuk)
            {
                minToplam += item;
                Console.WriteLine(item);
            }
            int minOrt = minToplam / enKucuk.Length;
            Console.WriteLine("Ortalaması: " + minOrt);

            Console.WriteLine("\nOrtalamaların Toplamı: " + (minOrt + maxOrt));
        }
    }
}
