using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace Odev03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInfo userInfo = new UserInfo();
            Console.WriteLine(userInfo.Info());
        }
    }
    class User
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Para { get; set; }
        public List<VisitedPlaces> VisitedPlaces { get; set; }
    }
    class VisitedPlaces
    {

        public string Ulke { get; set; }
        public string Sehri { get; set; }
        public int PostaKodu { get; set; }
        public Dictionary<string, string> TanistigiKisiler { get; set; }

    }
    class UserInfo
    {

        public  string Info()
        {        
            User user = new User();      

            user.Ad = "Sevda";
            user.Soyad = "İNCE";
            user.DogumTarihi = new DateTime(1997, 06, 27);
            user.Para = 1000;

            VisitedPlaces sehir1=new VisitedPlaces();
            sehir1.Ulke="Türkiye";
            sehir1.Sehri="Gaziantep";
            sehir1.PostaKodu=2700;            
            


            Dictionary<string,string> ark1=new Dictionary<string, string>();
            ark1.Add("01","Serdar İNCE");
            ark1.Add("02","Hasan İNCE");
            ark1.Add("03","Muzaffer İNCE");
            sehir1.TanistigiKisiler=ark1;

            List<VisitedPlaces> sehirler=new List<VisitedPlaces>();
            sehirler.Add(sehir1);


            
            user.VisitedPlaces=sehirler;

            string gezilenYerler = "";
            foreach (var gezilenYer in user.VisitedPlaces)
            {
                string kisiListesi = "";
                foreach (var kisi in gezilenYer.TanistigiKisiler)
                {
                    kisiListesi = kisiListesi + kisi.Value + ", ";
                }
                gezilenYerler = gezilenYerler + (gezilenYer.Ulke + ", " + gezilenYer.Sehri + "'de " + gezilenYer.TanistigiKisiler.Count + " kişi ile tanıştı bunlar sırası ile " + kisiListesi);
            }
            return $"{user.Ad} {user.Soyad} {gezilenYerler}";
        }
    }

}
