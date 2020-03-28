using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRDepartment.DataManagers;
using HRDepartment.DataModels;

namespace HRDepartment
{
    public partial class FormMain : Form
    {
        DepartmentManager _dm = new DepartmentManager();
        EmployeManager _em = new EmployeManager();
        public FormMain()
        {
            InitializeComponent();
            comboBoxDep.DisplayMember = "Name";
            listBoxEmp.DisplayMember = "Name";
            numericUpDownSalary.Maximum = decimal.MaxValue;
            numericUpDownSalary.Minimum = decimal.MinValue;
        }

        private void groupBoxPersonalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDepartments();
            DisplayEmployees();
        }

        private void comboBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEmployees();
        }

        private void listBoxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmp.SelectedIndex != -1)
            {
                Employe emp = listBoxEmp.SelectedItem as Employe;
                textBoxFullName.Text = emp.Name;
                dateTimePickerBday.Value = emp.Bday;
                textBoxEmail.Text = emp.Email;
                textBoxPhone.Text = emp.Phone;
                textBoxSocMedia.Text = emp.SocMedia;
                textBoxPosition.Text = emp.Position;
                numericUpDownSalary.Value = emp.Salary;
                rTextBoxSkills.Text = emp.Skills;
            }
        }

        private void buttonAddDep_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemDep_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemEmp_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void DisplayDepartments()
        {
            _dm.LoadDepartment();
            comboBoxDep.Items.Clear();
            foreach (Department item in _dm.Departments)
                comboBoxDep.Items.Add(item);
            if (comboBoxDep.Items.Count > 0)
                comboBoxDep.SelectedIndex = 0;
        }
        private void DisplayEmployees()
        {
            listBoxEmp.Items.Clear();
            if (comboBoxDep.SelectedIndex != -1)
            {
                int depId = ((Department)comboBoxDep.SelectedItem).Id;
                _em.LoadEmployees();
                foreach (Employe item in _em.Employees)
                    if (item.DepartmentId == depId)
                        listBoxEmp.Items.Add(item);
                if (listBoxEmp.Items.Count > 0)
                    listBoxEmp.SelectedIndex = 0;
            }
        }
    }
}
