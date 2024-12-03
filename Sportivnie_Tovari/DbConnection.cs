
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportivnie_Tovari
{
    internal class DBConnection
    {
        private string _connectionString;

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }



    }

}

