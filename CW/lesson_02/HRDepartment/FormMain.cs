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
        DepartmentManager dm = new DepartmentManager();
        public FormMain()
        {
            InitializeComponent();
            comboBoxDep.DisplayMember = "Name";
        }

        private void groupBoxPersonalInfo_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDepartments();
        }

        private void comboBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            dm.LoadDepartment();
            comboBoxDep.Items.Clear();
            foreach (Department item in dm.Departments)
            {
                comboBoxDep.Items.Add(item);
            }
            if (comboBoxDep.Items.Count > 0)
                comboBoxDep.SelectedIndex = 0;
        }
    }
}
