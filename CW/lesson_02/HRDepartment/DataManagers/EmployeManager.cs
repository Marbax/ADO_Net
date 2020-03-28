using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRDepartment.DataModels;
using HRDepartment.DataProviders;

namespace HRDepartment.DataManagers
{
    class EmployeManager : DbProvider
    {
        private List<Employe> _employees;

        public List<Employe> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public EmployeManager()
        {
            _employees = new List<Employe>();
        }

        public void LoadEmployees()
        {
            string query = "getEmpList";

            _employees.Clear();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employe emp = new Employe()
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Bday = (DateTime)reader["Bday"],
                        Email = (string)reader["Email"],
                        Phone = (string)reader["Phone"],
                        SocMedia = (string)reader["SocMedia"],
                        Position = (string)reader["Position"],
                        Salary = (decimal)reader["Salary"],
                        Skills = reader["Skills"] as string,
                        DepartmentId = (int)reader["DepartmentId"]
                    };
                    _employees.Add(emp);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        public void AddDepartment(Department dep)
        {

        }

        public void RemoveDepartment(string name)
        {

        }

        public void RemoveDepartment(int id)
        {

        }

    }
}
