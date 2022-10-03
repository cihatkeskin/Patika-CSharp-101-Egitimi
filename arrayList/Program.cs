﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections namespace

            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');


            // İçerisindeki Verilere Erişim
            //Console.WriteLine(liste[1]);

            foreach (var item in liste)
               Console.WriteLine(item);


            // AddRange
            Console.WriteLine("\n**** AddRange ****");
            //string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);


            // Sort
            Console.WriteLine("\n**** Sort ****");
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);


            // Binary Search
            Console.WriteLine("\n**** Binary Search ****");
            Console.WriteLine(liste.BinarySearch(9));


            // Reverse
            Console.WriteLine("\n**** Reverse ****");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);


            // Clear
            Console.WriteLine("\n**** Clear ****");
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}
