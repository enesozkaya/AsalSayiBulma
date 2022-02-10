using System;
using System.Collections;

namespace AsalSayiBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            AsalSayi();
        }
        public static void AsalSayi()
        {
            ArrayList asalsayi = new ArrayList();
            ArrayList asaldegil = new ArrayList();
            Console.WriteLine("5 adet pozitif sayı giriniz");
            for (int i = 0; i < 5; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                while (sayi <= 0)
                {
                    Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                    sayi = Convert.ToInt32(Console.ReadLine());
                }

                if (AsalSayiMi(sayi))
                {
                    asalsayi.Add(sayi);
                }
                else
                {
                    asaldegil.Add(sayi);
                }

            }
            Console.WriteLine("**********sıralamalar***************");

            asalsayi = Sirala(asalsayi, true);
            asaldegil = Sirala(asaldegil, true);

            EkranaYaz(asalsayi);
            EkranaYaz(asaldegil);

            Console.WriteLine("***********Ortalamalar************");
            Console.WriteLine("Asal sayı ortalaması: " + OrtalamaHesaplama(asalsayi));
            Console.WriteLine("Asalolmayan Sayı ortalaması: " + OrtalamaHesaplama(asaldegil));

        }

        public static bool AsalSayiMi(int sayi)
        {
            int kontrol = 0;
            for (int j = 2; j < sayi; j++)
            {
                if (sayi % j == 0)
                {
                    kontrol++;
                    break;
                }
            }

            return kontrol > 0 ? false : true;
        }

        public static ArrayList Sirala(ArrayList list, bool isDesc)
        {
            list.Sort();
            if (isDesc)
            {
                list.Reverse();
                return list;
            }

            return list;
        }

        public static void EkranaYaz(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static decimal OrtalamaHesaplama(ArrayList list)
        {
            int toplam = 0;
            foreach (var item in list)
            {
                toplam += (int)item;
            }

            return toplam / list.Count;
        }
    }
}
