using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Лр_3_1;

namespace Лр_3
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            //connection string
            string host = "localhost";
            int port = 3306;
            string database = "world";
            string username = "monty";
            string password = "some_pass";
            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);

        }
    }
}
