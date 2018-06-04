using System;

namespace IDC
{
    class Program
    {
        static void Main(string[] args)
        {
            string m1 = Console.ReadLine();
            string m2 = Console.ReadLine();
            int deger = function.FarkHesapla(m1, m2);
            switch (deger)
            {
                case 1:
                Console.WriteLine("Metinler axynı");
                break;
                case 0:
                Console.WriteLine("Metinler aynı değil.");
                break;
            }
        }
    }
}
