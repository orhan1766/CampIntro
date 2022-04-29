using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.EgitmenAdi = "Engin";
            kurs1.IzlenmeYuzdesi = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.EgitmenAdi = "orhan";
            kurs2.IzlenmeYuzdesi = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.EgitmenAdi = "Semih";
            kurs3.IzlenmeYuzdesi = 75;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ ' ' + kurs.EgitmenAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string EgitmenAdi { get; set; }
        public int IzlenmeYuzdesi { get; set; }
    }
}
