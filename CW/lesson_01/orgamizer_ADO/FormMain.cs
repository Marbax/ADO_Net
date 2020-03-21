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
            UpdateOrganizerTasks();
            UpdateListBoxOrganizerTasks();
        }
        private void CustomInit()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["EventsMainServer"].ConnectionString;
            _connection = new SqlConnection(_connectionString);

            _categories = new List<Category>();
            _organizerTasks = new List<OrganizerTask>();

            comboBoxCategory.DisplayMember = "Name";
            listBoxTasks.DisplayMember = "Name";

            ToolTip tt = new ToolTip();
            tt.SetToolTip(buttonAddTask, "Adding new task to selected category with current data from task detail fields");
            tt.SetToolTip(buttonEditTask, "Change details of selected task on that you wrote in detail fields");
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
                try
                {
                    _connection.Open();
                    SqlCommand command = new SqlCommand(query, _connection);
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name; //параметризованый запрос ,от инйекций
                    command.ExecuteNonQuery();
                }
                finally
                {
                    _connection.Close();
                }
                UpdateCategories();
                UpdateComboBoxCategories();
            }
        }

        /// <summary>
        /// 1. Удаление категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            if (_categories.Count > 0)
            {
                FormRemoveCategory fmc = new FormRemoveCategory() { Categories = _categories };
                if (fmc.ShowDialog() == DialogResult.OK)
                {
                    fmc.ToRemoveCategories.ForEach(trc => _categories.Remove(trc));
                    int[] cat_indexes = fmc.ToRemoveCategories.Select(c => c.Id).ToArray();
                    cat_indexes.ToList().ForEach(i => _organizerTasks.RemoveAll(t => t.CategoryId == i));

                    try
                    {
                        _connection.Open();
                        foreach (int item in cat_indexes)
                        {
                            string queryOrgTask = "delete from OrganizerTask where CategoryId=@item";
                            SqlCommand commandOrgTask = new SqlCommand(queryOrgTask, _connection);
                            commandOrgTask.Parameters.Add("@item", SqlDbType.Int).Value = item;
                            commandOrgTask.ExecuteNonQuery();

                            string queryCat = "delete from Category where Id=@item";
                            SqlCommand commandCat = new SqlCommand(queryCat, _connection);
                            commandCat.Parameters.Add("@item", SqlDbType.Int).Value = item;
                            commandCat.ExecuteNonQuery();
                        }
                    }
                    finally
                    {
                        _connection.Close();
                    }
                    //UpdateCategories();
                    UpdateComboBoxCategories();
                }
            }
        }

        /// <summary>
        /// 4. Добавление задач
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex != -1)
            {
                string name = textBoxTaskName.Text;
                string desc = richTextBoxTaskDescription.Text;
                string term = textBoxTaskDeadline.Text;
                if (!string.IsNullOrEmpty(name.Trim(' ')) && !string.IsNullOrEmpty(desc.Trim(' ')) && !string.IsNullOrEmpty(term.Trim(' ')))
                {
                    int catId = ((Category)comboBoxCategory.SelectedItem).Id;
                    string query = "insert into OrganizerTask (Name,Description,Term,CategoryId) values (@name,@desc,@term,@catId)";
                    try
                    {
                        _connection.Open();
                        SqlCommand command = new SqlCommand(query, _connection);
                        command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
                        command.Parameters.Add("@desc", SqlDbType.NVarChar, 50).Value = desc;
                        command.Parameters.Add("@term", SqlDbType.NVarChar, 50).Value = term;
                        command.Parameters.Add("@catId", SqlDbType.Int).Value = catId;
                        command.ExecuteNonQuery();
                    }
                    finally
                    {
                        _connection.Close();
                    }
                    UpdateOrganizerTasks();
                    UpdateListBoxOrganizerTasks();
                }
            }
        }

        /// <summary>
        /// 5. Удаление задач
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                if (MessageBox.Show("Task will be permanently deleted", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
                    {
                        int taskId = ((OrganizerTask)listBoxTasks.SelectedItem).Id;
                        _organizerTasks.Remove((OrganizerTask)listBoxTasks.SelectedItem);
                        _connection.Open();
                        string query = "delete from OrganizerTask where Id=@taskId";
                        SqlCommand cmd = new SqlCommand(query, _connection);
                        cmd.Parameters.Add("@taskId", SqlDbType.Int).Value = taskId;
                        cmd.ExecuteNonQuery();
                        UpdateListBoxOrganizerTasks();
                    }
                    finally
                    {
                        _connection.Close();
                    }
                }
            }
        }

        /// <summary>
        /// 6. Редактирование задач
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex != -1 && listBoxTasks.SelectedIndex != -1)
            {
                string name = textBoxTaskName.Text;
                string desc = richTextBoxTaskDescription.Text;
                string term = textBoxTaskDeadline.Text;
                int taskId = ((OrganizerTask)listBoxTasks.SelectedItem).Id;
                if (!string.IsNullOrEmpty(name.Trim(' ')) && !string.IsNullOrEmpty(desc.Trim(' ')) && !string.IsNullOrEmpty(term.Trim(' ')))
                {
                    string query = "update OrganizerTask set Name=@name , Description=@desc , Term=@term where Id=@taskId";
                    try
                    {
                        _connection.Open();
                        SqlCommand command = new SqlCommand(query, _connection);
                        command.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
                        command.Parameters.Add("@desc", SqlDbType.NVarChar, 50).Value = desc;
                        command.Parameters.Add("@term", SqlDbType.NVarChar, 50).Value = term;
                        command.Parameters.Add("@taskId", SqlDbType.Int).Value = taskId;
                        command.ExecuteNonQuery();
                    }
                    finally
                    {
                        _connection.Close();
                    }
                    UpdateOrganizerTasks();
                    UpdateListBoxOrganizerTasks();
                }
            }

        }

        private void buttonResetTask_Click(object sender, EventArgs e)
        {
            textBoxTaskName.Text = richTextBoxTaskDescription.Text = textBoxTaskDeadline.Text = "";
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxOrganizerTasks();
            if (listBoxTasks.Items.Count == 0)
                this.buttonResetTask_Click(sender, e);
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
                UpdateTaskDetails();
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
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(query, _connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Category tmp_cat = new Category() { Id = (int)dataReader["Id"], Name = (string)dataReader["Name"] }; // read from RAM
                    _categories.Add(tmp_cat);
                }
            }
            finally
            {
                _connection.Close();
            }
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

        private void UpdateOrganizerTasks()
        {
            _organizerTasks.Clear();
            string query = "select * from OrganizerTask";
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(query, _connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    OrganizerTask tmp_task = new OrganizerTask() { Id = (int)dataReader["Id"], Name = (string)dataReader["Name"], Description = (string)dataReader["Description"], Term = (string)dataReader["Term"], CategoryId = (int)dataReader["CategoryId"] };
                    _organizerTasks.Add(tmp_task);
                }
            }
            finally
            {
                _connection.Close();
            }

        }
        /// <summary>
        /// 2. Отображение списка задач заданной категории
        /// </summary>
        private void UpdateListBoxOrganizerTasks()
        {
            listBoxTasks.Items.Clear();
            if (_organizerTasks.Count > 0)
            {
                listBoxTasks.Items.AddRange(_organizerTasks.Where(ot => ot.CategoryId == ((Category)comboBoxCategory.SelectedItem).Id).ToArray());
                if (listBoxTasks.Items.Count > 0)
                    listBoxTasks.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 3. Отображение детальной информации при выборе задачи
        /// </summary>
        private void UpdateTaskDetails()
        {
            OrganizerTask tmp_task = (OrganizerTask)listBoxTasks.SelectedItem;
            textBoxTaskName.Text = tmp_task.Name;
            richTextBoxTaskDescription.Text = tmp_task.Description;
            textBoxTaskDeadline.Text = tmp_task.Term;
        }
    }
}
