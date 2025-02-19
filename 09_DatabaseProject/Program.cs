using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net

            Console.WriteLine("***** C# Ürün-Kategori Bilgi Sistemi ");
            Console.WriteLine();
            Console.WriteLine();

            string tablenumber;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış ");
            Console.Write("Getirmek istediğiniz tablo numarasını gir ");
            tablenumber = Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=hasan;Integrated Security=True;Trust Server Certificate=True");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }



            Console.Read();


        }
    }
}