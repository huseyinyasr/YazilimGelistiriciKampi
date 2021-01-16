using System;

namespace YazilimGelistiriciKampi
{
    class Program
    {
        static void Main(string[] args)
        {
            //double - ondalık sayılar
            //int - sayı
            //bool - sisteme giriş yapmış mı?
            
            string katagoriEtiketi = "Katagoriler";
            bool sistemeGirisYapilmisMi = false;

            Console.WriteLine("Katagoriler");
            
            if (sistemeGirisYapilmisMi ==true)
            {
                Console.WriteLine("Tamam çıkabilirsin canım");
            }

            else
            {
                Console.WriteLine("Giriş yap lan puşt");
            }

            string dolarKuru = "Dolar kuru";
            int dolarDun = 5;
            int dolarBugun = 6;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış oku");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış oku");

            }

            else
            {
                Console.WriteLine("berabere");
            }

        }
    }
}
