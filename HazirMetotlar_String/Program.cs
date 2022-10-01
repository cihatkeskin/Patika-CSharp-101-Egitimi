using System;

namespace HazirMetotlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken1 = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp";
            string degisken3 = "dersimiz CSharp, Hoşgeldiniz!";

            // Length
            Console.WriteLine(degisken1.Length);

            // ToUpper, ToLower
            Console.WriteLine(degisken1.ToUpper());
            Console.WriteLine(degisken1.ToLower());

            // Concat
            Console.WriteLine(String.Concat(degisken1," Merhaba!"));

            // Compare, CompareTo
            Console.WriteLine(degisken1.CompareTo(degisken2)); // degisken1 in karakter sayısı degisken2 den fazla. 0, 1, -1 
            Console.WriteLine(String.Compare(degisken1, degisken3, true)); // Büyük, küçük harf duyarlılığı olacağı için 0 dönecek.
            Console.WriteLine(String.Compare(degisken1, degisken3, false)); // Büyük, küçük harf duyarlılığı olmayacağı için 1 dönecek.

            // Contains
            Console.WriteLine(degisken1.Contains(degisken2)); // degisken1 in içinde, degisken2 var mı ?
            Console.WriteLine(degisken1.EndsWith("Hoşgeldiniz!")); // Hoşgeldiniz! ile bitiyor mu ?
            Console.WriteLine(degisken1.StartsWith("Merhaba!")); // Merhaba! ile başlıyor mu ?

            // IndexOf
            Console.WriteLine(degisken1.IndexOf("CS")); // CS yi arayacak bulursa C'nin indexini dönecek.
            Console.WriteLine(degisken1.IndexOf("Cihat")); // Bulamazsa -1 döner.

            // Insert
            Console.WriteLine(degisken1.Insert(0, "Merhaba! ")); // 0. indexten başlayarak stringin başına ekler.
            Console.WriteLine(degisken1.LastIndexOf("i"));

            // PadLeft, PadRight
            Console.WriteLine(degisken1 + degisken2.PadLeft(30));
            Console.WriteLine(degisken1 + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken1.PadRight(50) + degisken2);
            Console.WriteLine(degisken1.PadRight(50,'-') + degisken2);

            // Remove 
            Console.WriteLine(degisken1.Remove(10));
            Console.WriteLine(degisken1.Remove(5, 3));
            Console.WriteLine(degisken1.Remove(0, 1));

            // Replace
            Console.WriteLine(degisken1.Replace("CSharp", "C#"));
            Console.WriteLine(degisken1.Replace(" ", "*"));

            // Split
            Console.WriteLine(degisken1.Split(' ')[1]); // Boşluklara göre parçala, bir diziye ata ve bana 1. indexi getir.

            // Substring
            Console.WriteLine(degisken1.Substring(4));
            Console.WriteLine(degisken1.Substring(4, 6));
        }
        
    }
}
