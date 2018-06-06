using System;

namespace IDC
{
    class Program
    {
        public static double carpan;
        public static int bolen;
        public static void Main(string[] args)
        { 
            
            Console.WriteLine("1.Original algorithm");
            Console.WriteLine("2.New algorithm");
            int chose = Convert.ToInt32(Console.ReadLine());
            
            switch (chose)
            {
                case 1:
                carpan = 3.2;
                bolen = 20;
                break;
                case 2:
                carpan = 2.7;
                bolen = 27;
                break;
            }
            string m1 = Console.ReadLine();
            string m2 = Console.ReadLine();
            int deger = function.FarkHesapla(m1, m2);

            switch (deger)
            {
                case 1:
                Console.WriteLine("Metinler aynı");
                break;
                case 0:
                Console.WriteLine("Metinler aynı değil.");
                break;
            }
        }
    }
}
