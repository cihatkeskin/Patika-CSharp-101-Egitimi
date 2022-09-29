﻿using System;

namespace MetodTanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            // erisim_belirteci geri_donustipi metod_adi(parametleListesi/arguman)
            //{
            //komutlar;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metodlar ornek = new Metodlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metodlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1++;
            deger2++;

            return deger1 + deger2;
        }
    }
}
