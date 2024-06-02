using System;
using MySql.Data.MySqlClient;
using Лр_3;

namespace Лр_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection...");
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Opening Connection...");
                conn.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.Read();
        }
       
        
    }
}
