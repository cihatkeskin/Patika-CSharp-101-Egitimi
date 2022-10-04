using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            // -> ArrayList sınıfını kullanarak yazınız.
            // -> Negatif ve numeric olmayan girişleri engelleyin.
            // -> Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // -> Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int sayac;

            try
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine($"\n{i + 1}. sayıyı giriniz: ");
                    int sayi = int.Parse(Console.ReadLine());

                    if (sayi < 0)
                    {
                        throw new Exception("Negatif bir değer girilemez.");
                    }

                    sayac = 0;

                    for (int j = 2; j < sayi; j++)
                    {
                        if (sayi % j == 0)
                            sayac++;
                    }

                    if (sayac == 0)
                        asalSayilar.Add(sayi);

                    else
                        asalOlmayanSayilar.Add(sayi);
                }
            }

            catch (FormatException)
            {
                throw new Exception("Numeric olmayan bir değer girilemez.");
            }


            double toplam1 = 0;
            asalSayilar.Sort();
            asalSayilar.Reverse();
            Console.WriteLine("\n*** Asal Sayılar ***");
            foreach (var item in asalSayilar)
            {
                toplam1 += (int)item;
                Console.WriteLine(item);
            }
            Console.WriteLine("Eleman Sayısı: " + asalSayilar.Count);
            Console.WriteLine("Ortalaması: " + (toplam1 / asalSayilar.Count));

            double toplam2 = 0;
            asalOlmayanSayilar.Sort();
            asalOlmayanSayilar.Reverse();
            Console.WriteLine("\n*** Asal Olmayan Sayılar ***");
            foreach (var item in asalOlmayanSayilar)
            {
                toplam2 += (int)item;
                Console.WriteLine(item);
            }
            Console.WriteLine("Eleman Sayısı: " + asalOlmayanSayilar.Count);
            Console.WriteLine("Ortalaması: " + (toplam2 / asalOlmayanSayilar.Count));
        }
    }
}
