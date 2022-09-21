﻿using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdir.

            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayac; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }


            // 1 ile 1000 arasindaki tek ve cift sayılarin toplamini ekrana yazdir.

            int tekToplam = 0, ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 1)
                {
                    tekToplam += i;
                }

                else
                {
                    ciftToplam += i;
                }
            }

            Console.WriteLine("Tek sayilarin toplami: " + tekToplam + "\nCift sayilarin toplami: " + ciftToplam);


            // Break, Continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
