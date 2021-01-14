using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç";
            string kurs3 = "java";

            // array -dizi liste

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç" , "java" };


              for (int i = 0; i < kurslar.Length; i ++)
             {
                Console.WriteLine(kurslar[i]);
             }


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



              Console.WriteLine("Sayfa Sonu-footer");
        }
    }
}
