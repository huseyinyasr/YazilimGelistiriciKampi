using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //length - eleman sayısı kadar
            //array - dizi

            string[] kurslar = new string[] {"Yazılım Geliştirme Kampı",
                "Programlama","java","bi kurs","bi kurs daha"};



            for (int i = 0; i< kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            //foreach - dizi temelli yapıları tek tek dönmeye yarar

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonuna Geldin Usta");




        }
    }
}
