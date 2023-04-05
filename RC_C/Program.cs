using System;
using System.Data;
using System.Data.SqlClient;

namespace RC_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while(true)
            {
                try
                {
                    Console.WriteLine("Koneksi Ke Database\n");
                    Console.WriteLine("Masukkan User ID :");
                    string user = Console.ReadLine();
                    Console.WriteLine("Masukkan Password :");
                    string pass = Console.ReadLine();
                    Console.WriteLine("Masukkan Database Tujuan :");
                    string db = Console.ReadLine();
                    Console.WriteLine("\nKetik K untuk Terhubung ke Database :");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'K':
                            {
                                SqlConnection conn = null;
                                string strKoneksi = "Data source = LAPTOP\\CHENDY; " +
                                    "initial catalog = {0};" +
                                    "User ID = {1}; password = {2}";
                                conn = new SqlConnection(string.Format(strKoneksi, db, user, pass));
                                conn.Open();
                                Console.Clear();
                                while (true)
                    }
                }
            }
        }
    }
}
