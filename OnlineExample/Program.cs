using System;

namespace OnlineExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uygulama!");
            string cikis;
            do
            {
                Console.WriteLine("Not değerini giriniz (0-100) :");
                int not = Convert.ToInt32(Console.ReadLine());

                if (not < 0 || not > 100)
                {
                    Console.WriteLine("Yanlış not girdiniz.");
                }
                if (not > 0 || not < 100)
                {
                    switch (not)
                    {
                        case >85:Console.WriteLine("AA");break;
                        case >75:Console.WriteLine("BA");break;
                        case >65:Console.WriteLine("BB");break;                     
                        case >55:Console.WriteLine("CB");break;

                        default: Console.WriteLine("Dersten kaldınız!");
                            break;
                    }
                    
                }
                Console.WriteLine("Çıkış yapmak istiyor musunuz? Evet(E)");
                cikis = Convert.ToString(Console.ReadLine());
            } while (cikis!="E");
        }
    }
}
