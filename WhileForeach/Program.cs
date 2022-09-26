using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***WHILE***
            // 1 den baslayarak console dan girilen sayiya kadar (sayi dahil) ortalama hesaplayip, yazdirin.

            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0, sayac = 1;
            
            while (sayi >= sayac)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Ortalama: " + (toplam / sayi));


            // 'a' dan 'z' ye kadar tum harfleri console a yazdirin.

            char character = 'a';

            while (character <= 'z')
            {
                Console.WriteLine(character);
                character++;
            }


            // ***FOREACH*** 

            string[] arabalar = { "Mercedes", "Honda", "Volswagen", "Toyota" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
