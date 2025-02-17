using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //string[] colors = new string[2];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[2];

            //cities[0] = "Trabzon";
            //cities[1] = "İstanbul";

            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[10];

            //numbers[0] = 55;
            //numbers[1] = 15;
            //numbers[2] = 1;
            //numbers[3] = 98;
            //numbers[7] = 28;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Londra", "Roma", "Barcelona", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 125, 638, 488, 7456, 2365, 1122 };

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] my_array = { 47, 85, 96, 87, 32, 152, 658, 140 };

            //int maxnumber = my_array[0];

            //for (int i = 0; i < my_array.Length; i++)
            //{
            //    if (my_array[i] > maxnumber)
            //    {
            //        maxnumber = my_array[i];
            //    }
            //}

            //Console.WriteLine(maxnumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "birgül", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 1, 2, 45, 82, 86, 10, 35 };

            //Array.Sort(numbers);  Küçükten Büyüğe sıralıyor

            //for (int i = 0; i < numbers.Length; i++) { 
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 2, 45, 82, 86, 10, 35 };
            //Array.Reverse(numbers);  diziyi tersten tekrar yaızyor

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metodları

            //string[] customers = { "ali", "ahmet", "mehmet", "burak", "aysel", "kaya" };
            //int index = Array.IndexOf(customers, "aysel"); index numarası

            //Console.WriteLine(index);

            //int[] numbers = { 41, 55, 44, 21, 74, 1234, 2355, 212, 39 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() 
            //    + "Dizinin en küçük elemanı: " +  numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 27, 45, 11, 84, 24, 36, 15, 72, 4, 67542 };
            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tekler");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();

        }
    }
}