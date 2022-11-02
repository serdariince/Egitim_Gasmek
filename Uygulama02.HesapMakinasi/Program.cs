using System;

namespace Uygulama02.HesapMakinasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hesap makinası
            string dongu;
            do
            {
                Console.Write("İslem Türü Giriniz (Toplama(+), Çıkarma (-), Bölme (/), Çarpma(*)):");
                string islem = Convert.ToString(Console.ReadLine());

                Console.Write("1. Değer giriniz:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("1. Değer giriniz:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                switch (islem)
                {
                    case "+":
                        Toplama(sayi1, sayi2);
                        break;
                    case "-":
                        Cikar(sayi1, sayi2);
                        break;
                    case "/":
                        Bol(sayi1, sayi2);
                        break;
                    case "*":
                        Carp(sayi1, sayi2);
                        break;
                    default:
                        Console.WriteLine("Girilen islem türü hatalı");
                        break;
                }
                Console.Write("İşlem yapmayı sonlandırmak istiyor musunuz:(q)");
                 dongu = Convert.ToString(Console.ReadLine());


            } while (dongu!="q");

            

        }

        private static void Carp(int sayi1, int sayi2)
        {
            Console.Write("Çarpma işlemi sonucu :");
            Console.WriteLine(sayi2*sayi1);
        }
        private static void Bol(int sayi1, int sayi2)
        {
            Console.Write("Bölme işlemi sonucu :"+sayi1 / sayi2);
            Console.WriteLine(sayi1 / sayi2);
        }
        private static void Cikar(int sayi1, int sayi2)
        {
            Console.Write("Çıkarma işlemi sonucu :");
            Console.WriteLine( sayi1 - sayi2);
        }
        private static void Toplama(int sayi1, int sayi2)
        {
            Console.Write("Toplama işlemi sonucu :");
            Console.WriteLine(sayi1 + sayi2);
        }

  

    }
}
