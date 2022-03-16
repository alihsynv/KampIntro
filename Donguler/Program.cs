using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";

            //Array - Dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi",
                "Programlamaya baslangic icin temel kurs", 
                "Java", "Python", "C++" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("<<<<For Bitti>>>>");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            // While 
            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
