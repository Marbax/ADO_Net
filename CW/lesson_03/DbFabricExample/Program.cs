using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace DbFabricExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string _conStr = ConfigurationManager.ConnectionStrings["msSqlServ01"].ConnectionString;
            //another connection strings
            DbConnection _con = new SqlConnection(_conStr);
            //another connections

            DbProviderFactory _factory = DbProviderFactories.GetFactory(_con);

            DbCommand _cmd = _factory.CreateCommand();
            _cmd.CommandText = ("select * from Employee");
            _cmd.Connection = _con;
            _con.Open();
            DbDataReader _reader = _cmd.ExecuteReader();

            while (_reader.Read())
                Console.WriteLine($"{_reader["Id"]} - {_reader["Name"]} - {_reader["Position"]} - {_reader["Salary"]}\n");

            _reader.Close();
            _con.Close();

            Console.ReadLine();
        }

    }
}
