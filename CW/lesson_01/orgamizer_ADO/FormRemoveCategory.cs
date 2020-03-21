using System;
using System.Collections.Generic;
using System.Windows.Forms;
using orgamizer_ADO.models;

namespace orgamizer_ADO
{
    public partial class FormRemoveCategory : Form
    {
        public List<Category> Categories { private get; set; }

        public List<Category> ToRemoveCategories { get; private set; }

        public FormRemoveCategory()
        {
            InitializeComponent();
        }

        private void FormRemoveCategory_Load(object sender, EventArgs e)
        {
            Categories.ForEach(c => listBoxCategories.Items.Add(c));
            listBoxCategories.DisplayMember = "Name";
            if (listBoxCategories.Items.Count > 0)
                listBoxCategories.SelectedIndex = 0;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (ToRemoveCategories == null)
                ToRemoveCategories = new List<Category>();

            if (listBoxCategories.SelectedIndex != -1)
            {
                foreach (Category item in listBoxCategories.SelectedItems)
                    ToRemoveCategories.Add(item);
                UpdateListCategories(ToRemoveCategories);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            if (ToRemoveCategories == null || ToRemoveCategories.Count == 0)
                this.DialogResult = DialogResult.Cancel;
            else
                this.DialogResult = DialogResult.OK;
        }

        private void UpdateListCategories(List<Category> toRemCategories)
        {
            toRemCategories.ForEach(trc => Categories.Remove(trc));
            listBoxCategories.Items.Clear();
            Categories.ForEach(c => listBoxCategories.Items.Add(c));
        }

        private void listBoxCategories_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.buttonCancel_Click(sender, e);
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                this.buttonRemove_Click(sender, e);
            if (e.KeyCode == Keys.Enter)
                this.buttonSaveAndExit_Click(sender, e);
        }
    }
}
