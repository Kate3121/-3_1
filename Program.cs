using System;
using System.Data.Common;
using MySql.Data.MySqlClient;
using Лр_3;

namespace Лр_3_1
{
    class Program
    {
        static void Main(string[] args)
        {//Получить объект Connection подключенный к DB.
            Console.WriteLine("Getting Connection...");
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Opening Connection...");
                conn.Open();
                Console.WriteLine("Connection successful!");
                QueryEmployee(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                //Закрыть соединение
                conn.Close();
                //Уничтожить объект, освободить ресурс
                conn.Dispose();
            }
            Console.Read();
        }
        private static void QueryEmployee(MySqlConnection conn)
        {
            string id, name, country;
            string sql = "Select Code, Name, Continent from country";
            //создать объект Command
            MySqlCommand cmd = new MySqlCommand();

            //сочетать Command c Connection
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader["Code"].ToString();
                        name = reader["Name"].ToString();
                        country = reader["Continent"].ToString();
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("Код:" + id + " Название:" + name + " Континент:" + country);
                        Console.WriteLine("------------------------------------------------------------------");

                    }
                }
            }
        }

    }
}
