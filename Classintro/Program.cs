using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "ilke";
            int yas = 26;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "ilke Basalak";
            kurs1.IzlenmOrani = 68;



            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Dicle Demir";
            kurs2.IzlenmOrani = 64;



            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Meryem Bulut";
            kurs3.IzlenmOrani = 80;


            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

        }
    }



}

