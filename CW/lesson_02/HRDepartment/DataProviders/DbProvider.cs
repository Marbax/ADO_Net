using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace HRDepartment.DataProviders
{
    class DbProvider
    {
        private string _connectionString;
        protected SqlConnection _conn;

        public DbProvider()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["HRDb"].ConnectionString;
            _conn = new SqlConnection(_connectionString);
        }
    }
}
