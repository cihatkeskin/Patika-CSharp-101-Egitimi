using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru 1 - Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan çift olanları console'a yazdırın.

            Console.WriteLine("**** Soru - 1 *****");

            Console.WriteLine("Kac adet sayi gireceksiniz ? ");
            int a = int.Parse(Console.ReadLine());
            int[] sayilar = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("\n{0}. pozitif sayiyi giriniz:", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nCift Sayilar:");
            foreach (var sayi in sayilar)
            {
                if (sayi % 2 == 0)
                    Console.WriteLine(sayi);
            }


            // Soru 2 - Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("\n\n**** Soru - 2 *****");

            Console.WriteLine("Kac adet sayi gireceksiniz ? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBolmesini istediginiz sayiyi giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] sayilar2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n{0}. pozitif sayiyi giriniz:", i + 1);
                sayilar2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n{0} sayısına esit ya da tam bolunenler.", m);
            foreach (var sayi in sayilar2)
            {
                if (sayi % m == 0)
                {
                    Console.WriteLine(sayi);
                }
            }


            // Soru 3 - Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("\n\n**** Soru - 3 *****");

            Console.WriteLine("Kac adet kelime gireceksiniz ? ");
            int adet = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("\n{0}. kelimeyi giriniz:", i + 1);
                kelimeler[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeler);
            Console.WriteLine("\nSonuc: ");
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }


            // Soru 4 - Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            // Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("\n\n**** Soru - 4 *****");

            Console.WriteLine("Bir cumle yaziniz: ");
            string cumle = Console.ReadLine();

            int sayac = 0;
            string[] kelimeler2 = cumle.Split(" ");

            Console.WriteLine("\nKelime Sayisi: " + kelimeler2.Length);

            for (int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i] != ' ')
                {
                    sayac++;
                }
            }

            Console.WriteLine("Harf Sayisi: " + sayac);
        }
    }
}
