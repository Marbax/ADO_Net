using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Common;// fabric
//using System.Data.Odbc; // old db ,deprecated
using System.Data.SqlClient;
using System.Configuration; // dynamic lib (also u should add it in references)
using orgamizer_ADO.models;

namespace orgamizer_ADO
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventsDB.mdf;Integrated Security=True
        /// </summary>
        string _connectionString;
        SqlConnection _connection; // will rule your connection
        List<Category> _categories;
        List<OrganizerTask> _organizerTasks;
        public FormMain()
        {
            InitializeComponent();
            CustomInit();
            UpdateCategories();
            UpdateComboBoxCategories();
        }
        private void CustomInit()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["EventsMainServer"].ConnectionString;
            _connection = new SqlConnection(_connectionString);

            _categories = new List<Category>();
            _organizerTasks = new List<OrganizerTask>();

            comboBoxCategory.DisplayMember = "Name";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddCategory fac = new FormAddCategory() { CatName = " " };
            if (fac.ShowDialog() == DialogResult.OK)
            {
                string name = fac.CatName;
                string query = "insert into Category (Name) values (@name)";
                _connection.Open();
                SqlCommand command = new SqlCommand(query, _connection);
                command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name; //параметризованый запрос ,от инйекций
                command.ExecuteNonQuery();
                _connection.Close();
                UpdateCategories();
                UpdateComboBoxCategories();
            }
        }

        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetTask_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTaskDeadline_TextChanged(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///------------------------------------------____Methods____----------------------------------------------------------------------------
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void UpdateCategories()
        {
            _categories.Clear();
            string query = "select * from Category";
            _connection.Open();
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Category tmp_cat = new Category() { Id = (int)dataReader["Id"], Name = (string)dataReader["Name"] }; // read from RAM
                _categories.Add(tmp_cat);
            }
            _connection.Close();
        }

        private void UpdateComboBoxCategories()
        {
            comboBoxCategory.Items.Clear();
            if (_categories.Count > 0)
            {
                comboBoxCategory.Items.AddRange(_categories.ToArray());
                comboBoxCategory.SelectedIndex = 0;
            }
        }
    }
}
