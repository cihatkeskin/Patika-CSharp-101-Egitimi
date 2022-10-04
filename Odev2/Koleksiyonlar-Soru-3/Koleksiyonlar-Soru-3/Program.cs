using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
            // ve dizinin elemanlarını sıralayan programı yazınız.

            string sesliHarfler = "aeıioöuü";

            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            ArrayList sesliHarfDizisi = new ArrayList();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (sesliHarfler.Contains(cumle[i]))
                    sesliHarfDizisi.Add(cumle[i]);
            }

            sesliHarfDizisi.Sort();
            Console.WriteLine();
            foreach (var item in sesliHarfDizisi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
