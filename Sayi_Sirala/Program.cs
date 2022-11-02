using System;

namespace Sayi_Sirala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degisken;
           
            int[] sayilar = { 1, 7, 6, 8, 9, 10 };

            Console.WriteLine("Mevcut sayılar");
            foreach (var sayi in sayilar)
            {
                Console.Write(sayi+",");
            }
            

            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = 0; j < sayilar.Length; j++)
                {
                    degisken = sayilar[i];
                    if (degisken < sayilar[j])
                    {
                        degisken = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = degisken;
                    }
                }
            }
            Console.WriteLine("");

            Console.WriteLine("Sıralanmış sayılar");
            foreach (var sayi in sayilar)
            {
                Console.Write(sayi + ",");
            }
        }
    }
}
