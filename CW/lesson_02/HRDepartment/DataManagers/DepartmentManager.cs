using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HRDepartment.DataProviders;
using HRDepartment.DataModels;

namespace HRDepartment.DataManagers
{
    class DepartmentManager : DbProvider
    {
        private List<Department> _departments;

        public List<Department> Departments
        {
            get { return _departments; }
            set { _departments = value; }
        }

        public DepartmentManager()
        {
            _departments = new List<Department>();
        }

        public void LoadDepartment()
        {
            string query = "getDepList";

            _departments.Clear();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Department dep = new Department() { Name = (string)reader["Name"] };
                    _departments.Add(dep);
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
