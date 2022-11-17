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
        User user = new User()
        {
            Ad = "Sevda",
            Soyad = "İNCE",
            DogumTarihi = new DateTime(1997, 06, 27),
            Para = 1000,
            VisitedPlaces = new List<VisitedPlaces>() {
                new VisitedPlaces { Ulke="Turkiye",Sehri="Gaziantep",PostaKodu=2700,TanistigiKisiler=new Dictionary<string, string>(){{"01", "Serdar İnce"},}},
                new VisitedPlaces { Ulke="Turkiye",Sehri="Nevşehir",PostaKodu=50040,TanistigiKisiler=new Dictionary<string, string>(){{"01", "Sara Algan"}}},
            },
        };
        public string Info()
        {
            string gezilenYerler = "";
            string cumle = "";
            foreach (var gezilenYer in user.VisitedPlaces)
            {
                string kisiListesi = "";
                foreach (var kisi in gezilenYer.TanistigiKisiler)
                {
                    kisiListesi = kisiListesi + kisi.Value + ", ";
                }
                gezilenYerler = gezilenYerler + (" Ülke:" + gezilenYer.Ulke + " Şehir:" + gezilenYer.Sehri + " Posta Kodu :" + gezilenYer.PostaKodu + " " + gezilenYer.TanistigiKisiler.Count + " kişi ile tanıştı bunlar sırası ile :" + kisiListesi);
            }
            cumle = user.Ad + " " + user.Soyad;
            return cumle + " " + gezilenYerler;
        }
    }

}
