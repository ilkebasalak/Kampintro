using System;

namespace Kampintroo
{
    class Program
    {
        static void Main(string[] args)
        {


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            double dolarBugun = 7.35;
            double dolarDun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış");
             }
             

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Eşit");
            }




            bool sistemeGirisYapmismi = true;

            if (sistemeGirisYapmismi == true)

            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            else
            {
                Console.WriteLine("Giriş yap butonu");

            }

            Console.WriteLine(kategoriEtiketi);



            
            








           


            

        }
    }
}
