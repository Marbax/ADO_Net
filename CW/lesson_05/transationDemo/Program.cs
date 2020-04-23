using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace transationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string _conStr = ConfigurationManager
                .ConnectionStrings["TransDemo"].ConnectionString;
            SqlConnection _conn = new SqlConnection(_conStr);
            SqlCommand _cmd = _conn.CreateCommand();

            SqlTransaction _tran = null;

            try
            {
                _conn.Open();
                _tran = _conn.BeginTransaction();
                _cmd.Transaction = _tran;

                int goodId = 1;
                int goodsAmount = 2;

                _cmd.CommandText = $"insert into Sales (SaleDate , ProductId , Amount) " +
                    $"values ('2020-04-22 13:25',{goodId},{goodsAmount})";
                _cmd.ExecuteNonQuery();
                Console.WriteLine("\t\tInsert successful");

                _cmd.CommandText = $"update Goods set Amount = Amount - {goodsAmount}" +
                    $"where Id = {goodId}";
                _cmd.ExecuteNonQuery();
                Console.WriteLine("\t\tUpdate successful");

                _tran.Commit();
                Console.WriteLine("\t\tTransaction commited");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                _tran.Rollback();
            }
            finally
            {
                if (_conn.State != ConnectionState.Closed)
                    _conn.Close();
            }

            Console.ReadLine();
        }
    }
}
