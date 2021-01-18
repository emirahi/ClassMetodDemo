using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        private static MusteriManager manager;
        private static List<Musteri> liste;

        static void Main(string[] args)
        {
            manager = new MusteriManager();
            Musteri musteri1 = new Musteri
            {
                id = 1,
                tcKimlikNo = "12345678912",
                firstName = "emir",
                lastName = "ahi",
                balance = 3500
            };


            Musteri musteri2 = new Musteri
            {
                id = 2,
                tcKimlikNo = "11336688992",
                firstName = "orhan",
                lastName = "pamuk",
                balance = 4500
            };

            Musteri musteri3 = new Musteri
            {
                id = 3,
                tcKimlikNo = "12345678998",
                firstName = "halide",
                lastName = "edip adıvar",
                balance = 5500
            };
            manager.musteriEkle(musteri1);
            manager.musteriEkle(musteri2);
            manager.musteriEkle(musteri3);

            listele();
            Console.ReadLine();

            Console.WriteLine("id : 3 sil");
            manager.musteriSil(musteri3);
            listele();
            Console.ReadLine();

            Console.WriteLine("id : 2  Maaş değiştir");
            Musteri _musteri2 = new Musteri
            {
                id = 2,
                tcKimlikNo = "11336688992",
                firstName = "orhan",
                lastName = "pamuk",
                balance = 20500
            };
            manager.musteriGuncelle(_musteri2);
            listele();
            Console.ReadLine();
        }

        public static void listele()
        {
            liste = manager.musteriList();
            foreach (var item in liste)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.tcKimlikNo);
                Console.WriteLine(item.firstName);
                Console.WriteLine(item.lastName);                
                Console.WriteLine(item.balance);
                Console.WriteLine("----------------------------------");
            }

        }
    }
}
