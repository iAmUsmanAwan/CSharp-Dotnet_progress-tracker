using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Lec21_23_ADO
{
    public class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper(string connString)
        {
            connectionString = connString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
