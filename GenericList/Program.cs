using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T => object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");


            // Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);


            // List.ForEach
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // Listeden Eleman Çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // Liste İçerisinde Arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu!");


            // Eleman ile İndex'e Erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));


            // Diziyi List'e Çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<string> hayvanListesi = new List<string>(hayvanlar);


            // Listeyi Temizleme
            hayvanListesi.Clear();


            // List içerisinde nesne tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Cihat";
            kullanici1.Soyisim = "Keskin";
            kullanici1.Yas = 23;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Ayşe";
            kullanici2.Soyisim = "Yılmaz";
            kullanici2.Yas = 20;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar() {
                Isim = "Deniz",
                Soyisim = "Kocak",
                Yas = 24
            });

            kullaniciListesi.ForEach(kullanici => Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim +
                "\nKullanıcı Soyadı: " + kullanici.Soyisim + "\nKullanıcı Yaş: " + kullanici.Yas));

            yeniListe.Clear();
        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
        
    }
}
