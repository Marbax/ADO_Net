using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDepartment.DataModels
{
    class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Bday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SocMedia { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Skills { get; set; }
        public int DepartmentId { get; set; }
    }
}
