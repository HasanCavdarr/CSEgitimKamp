﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("1. Murat Yücedağ");
            //    Console.WriteLine("2. Hasan Çavdar");
            //    Console.WriteLine("3. Hakan Vural");
            //    Console.WriteLine("4. Ulaş Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1, y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();



            #endregion

            #region Değer Döndürmeyen String Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Aysel Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("AHMET", "yılmaz");
            //CustomerCard("Necla", "Kaya");

            #endregion

            #region  Değer Döndürmeyen Int Metotlar

            //void Sum(int number1, int number2, int number3)
            //{

            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //Sum(4, 5, 6);
            #endregion

            #region Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "İrem Aldemir";
            //}

            //CustomerName();

            //string StudentCard() {

            //    string name = "Mahmut";
            //    string surname = "Topçu";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region  Değer Döndüren String  

            //string CountryCard(string countryName, string capital, string flagColor)
            //{

            //    string cardInfo = "Ülke: "+ countryName + " - Başkent: "
            //        + capital + " - Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine(CountryCard("Türkiye","İstanbul","Kırmızı - Beyaz"));

            #endregion

            #region Değer Döndüren Int  Metotlar

            ////int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Örnek

            //string Examresult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi. Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(Examresult("Mert", 66, 25, 95));
            //Console.WriteLine(Examresult("Hasan", 40, 35, 65));

            #endregion

            Console.Read();

        }
    }
}