using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Şifrenizi giriniz: ");
            string password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı şifre!");
            }

            Console.Write("Başkenti giriniz: ");
            string capital = Console.ReadLine();
            Console.Write("Ülkeyi giriniz: ");
            string country = Console.ReadLine();

            if (capital == "ankara" & country == "türkiye")
            {
                Console.WriteLine("Bilgiler doğru");
            }
            else
            {
                Console.WriteLine("Yanlış bilgi girdiniz");
            }

            Console.Write("Bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Sayı doğru");
            }
            else
            {
                Console.WriteLine("Yanlış sayı girdiniz");
            }

            Console.Write("Birinci sınav notunu giriniz: ");
            int exam1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sınav notunu giriniz: ");
            int exam2 = int.Parse(Console.ReadLine());
            Console.Write("Üçüncü sınav notunu giriniz: ");
            int exam3 = int.Parse(Console.ReadLine());

            int average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Ortalama not: " + average);

            string result;
            if (average > 0 & average <= 50)
            {
                result = "Başarısız";
            }
            else if (average > 50 & average <= 70)
            {
                result = "Orta";
            }
            else if (average > 70 & average <= 84)
            {
                result = "İyi";
            }
            else
            {
                result = "Çok iyi";
            }
            Console.WriteLine(result);

            Console.Write("Bir şehir adı giriniz: ");
            string city = Console.ReadLine();
            if (city == "ankara" | city == "istanbul" | city == "trabzon")
            {
                Console.WriteLine("sehir listede mevcut");
            }
            else
            {
                Console.WriteLine("Listede yok");
            }

            Console.Write("Kullanıcı adınızı giriniz: ");
            string username = Console.ReadLine();
            if (username != "admin")
            {
                Console.Write("Bu kullanıcı adı alınamaz");
            }
            else
            {
                Console.WriteLine("Hoş geldiniz");
            }

            Console.Write("Birinci sayıyı giriniz: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("İşlem sembolünü giriniz (+, -, x, /): ");
            char symbol = char.Parse(Console.ReadLine());

            int calcResult;
            switch (symbol)
            {
                case '+':
                    calcResult = num1 + num2;
                    Console.WriteLine("Sonuç: " + calcResult);
                    break;
                case '-':
                    calcResult = num1 - num2;
                    Console.WriteLine("Sonuç: " + calcResult);
                    break;
                case '*':
                    calcResult = num1 * num2;
                    Console.WriteLine("Sonuç: " + calcResult);
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        calcResult = num1 / num2;
                        Console.WriteLine("Sonuç: " + calcResult);
                    }
                    else
                    {
                        Console.WriteLine("Sıfıra bölme hatası!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem!");
                    break;
            }

            Console.Read();
        }
    }
}