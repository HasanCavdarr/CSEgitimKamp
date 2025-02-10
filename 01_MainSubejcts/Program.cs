using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubejcts
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region yazdirmaKomutlari
            ////Console.WriteLine("Merhaba Dünya");
            ////Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            //Console.Read();
            #endregion

            #region String Degiskenler
            //string name;
            //name = "Murat";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Aydın";
            //customerPhone = "+90 500 000 40 61";
            //customerEmail = "deneme@gmail.com";
            //district = "Tuzla";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Hasan";
            //customerSurname = "Çavdar";
            //customerPhone = "+90 454 452 1135";
            //customerEmail = "asdfg@gmail.com";
            //district = "İzmit";
            //city = "Kocaeli";
            ////Console.WriteLine(customerName);
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------------------------------");

            #endregion

            #region Int Degiskenler
            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("------Kola: " + cokePrice);
            Console.WriteLine("------Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("------Kızartma: " + friesPrice + " TL");
            Console.WriteLine("------Su: " + waterPrice + " TL");


            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();

            int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount;
            int totalPrice = 0;

            // Ürün miktarları
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            // Toplam fiyat hesaplama
            totalPrice += hamburgerCount * hamburgerPrice;
            totalPrice += cokeCount * cokePrice;
            totalPrice += waterCount * waterPrice;
            totalPrice += friesCount * friesPrice;
            totalPrice += pizzaCount * pizzaPrice;
            totalPrice += lemonadeCount * lemonadePrice;

            Console.WriteLine("Toplam Fiyat: " + totalPrice + " TL");

            Console.Read();
            #endregion

            Console.Read();
        }


    }
}
