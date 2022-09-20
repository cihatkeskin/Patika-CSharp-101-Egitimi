using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydin!");
            else if (time <= 18)
                Console.WriteLine("Iyi gunler!");
            else
                Console.WriteLine("Iyi geceler!");

            string sonuc = time<=18 ? "Iyi gunler!" : "Iyi geceler!";

            Console.WriteLine(sonuc);

            sonuc = time>= 6 && time<11 ? "Gunaydin!" : time <= 18 ? "Iyi gunler!" : "Iyi geceler!";

            Console.WriteLine(sonuc);
        }
    }
}
