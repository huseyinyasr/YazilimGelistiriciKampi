using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {

            string baslik = "Bugün ne yiyeceğiz";

            Console.WriteLine(baslik);

            int dolarBugun = 6;
            int dolarDun = 5;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("yükseliş oku");

            }

            else if (dolarBugun<dolarDun)
            {

                Console.WriteLine("azalış oku");

            }

            else if(dolarBugun==dolarDun)
            {
                Console.WriteLine("eşit");
            }

        }
    }
}
