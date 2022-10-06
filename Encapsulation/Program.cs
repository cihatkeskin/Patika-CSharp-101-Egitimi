using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Cihat";
            ogrenci.Soyisim = "Keskin";
            ogrenci.OgrenciNo = 172114014;
            ogrenci.Sinif = 2;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 172114010, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }
    
    class Ogrenci
    {
        private string isim;

        private string soyisim;

        private int ogrenciNo;

        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif;
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif = 1;
                }
                else
                    sinif = value;
            } 
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("**** Öğrenci Bilgileri ****");
            Console.WriteLine($"Öğrencinin Adı: {this.Isim}");
            Console.WriteLine($"Öğrencinin Soyadı: {this.Soyisim}");
            Console.WriteLine($"Öğrencinin Numarası: {this.OgrenciNo}");
            Console.WriteLine($"Öğrencinin Sınıfı: {this.Sinif}");
            Console.WriteLine();
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
