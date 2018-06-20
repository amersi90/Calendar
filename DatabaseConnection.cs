using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    //TODO Create a class for databaseconnection, makes it easier to establish new connection and code looks cleaner
    class DatabaseConnection
    {
        private string _connectionString;
        private SqlConnection _sqc;
        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
            _sqc = new SqlConnection(_connectionString);

        }

       

    }
}
