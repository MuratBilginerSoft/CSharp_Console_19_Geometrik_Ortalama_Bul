using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Geometrik_Ortalama_Bul
{
    class Program
    {
        public static double toplam = 0;
        public static double çarpım = 1;
        public static double sayaç = 0;
        public static double y = 1;

        public static void ortalamabul()
        {
            Console.Write("Değeri Giriniz:");
            y = int.Parse(Console.ReadLine());
            çarpım *= y;
            sayaç++;
        }

        static void Main(string[] args)
        {
            int t;
            double geoorta;
            Console.Write("Kaç Değer Gireceksiniz:");
            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                ortalamabul();
            }

           
            geoorta = Math.Pow(çarpım, 1.0 / sayaç);

            Console.WriteLine("Geometrik Ortalama=" + geoorta);

            Console.ReadKey();
        }
    }
}
