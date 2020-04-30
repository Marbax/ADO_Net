using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;

namespace AsyncDemoWithDB
{
    public partial class MainForm : Form
    {
        DbConnection _conn = null;
        DbProviderFactory _fact = null;
        string _connStr = "";


        public MainForm()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string provName = "System.Data.sqlClient";
            _fact = DbProviderFactories.GetFactory(provName);
            _conn = _fact.CreateConnection();
            _connStr = ConfigurationManager.ConnectionStrings["DemoDB"].ConnectionString;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text.Trim(' ')))
                {
                    _conn.ConnectionString = _connStr;
                    await _conn.OpenAsync();
                    DbCommand cmd = _conn.CreateCommand();
                    cmd.CommandText = "waitfor delay '00:00:05';";
                    cmd.CommandText += textBox1.Text;

                    int rows = 0;
                    DataTable table = new DataTable();
                    label1.Text = "Query is proccesing.";

                    using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        bool fLine = true;
                        int collCount = reader.FieldCount;

                        do
                        {
                            while (await reader.ReadAsync())
                            {
                                if (fLine)
                                {
                                    for (int i = 0; i < collCount; i++)
                                        table.Columns.Add(reader.GetName(i));

                                    fLine = false;
                                }

                                DataRow row = table.NewRow();
                                for (int i = 0; i < collCount; i++)
                                    row[i] = await reader.GetFieldValueAsync<object>(i);

                                table.Rows.Add(row);
                                rows++;
                            }

                        } while (reader.NextResult());
                        label1.Text = $"Succesfully readed {rows} rows";
                        dataGridView1.DataSource = table;
                    }

                }
                else throw new ApplicationException("Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 5)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
