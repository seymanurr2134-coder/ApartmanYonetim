using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.DAL
{
    internal class DbHelper
    {
        private string connectionString =
           "Server=.\\SQLEXPRESS;Database=ApartmanDB;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
