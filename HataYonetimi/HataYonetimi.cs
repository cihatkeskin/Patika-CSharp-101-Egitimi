using System;

namespace HataYonetimi
{
    class HataYonetimi
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayi giriniz:");

                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("girmis oldugunuz sayi :" + sayi);
            }

            catch (Exception ex)
            {
                Console.WriteLine("hata: " + ex.Message.ToString());
            }

            finally
            {
                Console.WriteLine("İslem tamamlandi.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }

            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz.");
                Console.WriteLine(ex);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil.");
                Console.WriteLine(ex);
            }

            catch(OverflowException ex)
            {
                Console.WriteLine("Cok kücük ya da cok büyük bir deger girdiniz.");
                Console.WriteLine(ex);
            }

            finally
            {
                Console.WriteLine("İslem basariyla tamamlandi.");
             }
        }
        }
}
