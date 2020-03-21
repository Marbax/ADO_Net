namespace orgamizer_ADO
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelWorking = new System.Windows.Forms.Panel();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.labelTasks = new System.Windows.Forms.Label();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonResetTask = new System.Windows.Forms.Button();
            this.buttonEditTask = new System.Windows.Forms.Button();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.labelTaskDeadline = new System.Windows.Forms.Label();
            this.textBoxTaskDeadline = new System.Windows.Forms.TextBox();
            this.richTextBoxTaskDescription = new System.Windows.Forms.RichTextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.labelTaskName = new System.Windows.Forms.Label();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.panelWorking.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWorking
            // 
            this.panelWorking.Controls.Add(this.listBoxTasks);
            this.panelWorking.Controls.Add(this.labelTasks);
            this.panelWorking.Controls.Add(this.buttonRemoveCategory);
            this.panelWorking.Controls.Add(this.buttonAddCategory);
            this.panelWorking.Controls.Add(this.comboBoxCategory);
            this.panelWorking.Controls.Add(this.labelCategory);
            this.panelWorking.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWorking.Location = new System.Drawing.Point(0, 0);
            this.panelWorking.Name = "panelWorking";
            this.panelWorking.Padding = new System.Windows.Forms.Padding(3);
            this.panelWorking.Size = new System.Drawing.Size(302, 554);
            this.panelWorking.TabIndex = 0;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 16;
            this.listBoxTasks.Location = new System.Drawing.Point(3, 131);
            this.listBoxTasks.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.ScrollAlwaysVisible = true;
            this.listBoxTasks.Size = new System.Drawing.Size(296, 420);
            this.listBoxTasks.TabIndex = 5;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            // 
            // labelTasks
            // 
            this.labelTasks.AutoSize = true;
            this.labelTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTasks.Location = new System.Drawing.Point(12, 115);
            this.labelTasks.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.labelTasks.Name = "labelTasks";
            this.labelTasks.Size = new System.Drawing.Size(55, 16);
            this.labelTasks.TabIndex = 4;
            this.labelTasks.Text = "Tasks:";
            // 
            // buttonRemoveCategory
            // 
            this.buttonRemoveCategory.Location = new System.Drawing.Point(162, 61);
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.Size = new System.Drawing.Size(140, 23);
            this.buttonRemoveCategory.TabIndex = 3;
            this.buttonRemoveCategory.Text = "Remove Category";
            this.buttonRemoveCategory.UseVisualStyleBackColor = true;
            this.buttonRemoveCategory.Click += new System.EventHandler(this.buttonRemoveCategory_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(3, 61);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(140, 23);
            this.buttonAddCategory.TabIndex = 2;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(3, 19);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(296, 24);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(3, 3);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 15);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(75, 16);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Category:";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonResetTask);
            this.panelMain.Controls.Add(this.buttonEditTask);
            this.panelMain.Controls.Add(this.buttonRemoveTask);
            this.panelMain.Controls.Add(this.buttonAddTask);
            this.panelMain.Controls.Add(this.labelTaskDeadline);
            this.panelMain.Controls.Add(this.textBoxTaskDeadline);
            this.panelMain.Controls.Add(this.richTextBoxTaskDescription);
            this.panelMain.Controls.Add(this.labelTaskDescription);
            this.panelMain.Controls.Add(this.labelTaskName);
            this.panelMain.Controls.Add(this.textBoxTaskName);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(302, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(765, 554);
            this.panelMain.TabIndex = 1;
            // 
            // buttonResetTask
            // 
            this.buttonResetTask.Location = new System.Drawing.Point(536, 507);
            this.buttonResetTask.Name = "buttonResetTask";
            this.buttonResetTask.Size = new System.Drawing.Size(208, 35);
            this.buttonResetTask.TabIndex = 13;
            this.buttonResetTask.Text = "Reset Task";
            this.buttonResetTask.UseVisualStyleBackColor = true;
            this.buttonResetTask.Click += new System.EventHandler(this.buttonResetTask_Click);
            // 
            // buttonEditTask
            // 
            this.buttonEditTask.Location = new System.Drawing.Point(536, 466);
            this.buttonEditTask.Name = "buttonEditTask";
            this.buttonEditTask.Size = new System.Drawing.Size(208, 35);
            this.buttonEditTask.TabIndex = 12;
            this.buttonEditTask.Text = "Edit Selected Task";
            this.buttonEditTask.UseVisualStyleBackColor = true;
            this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.Location = new System.Drawing.Point(31, 507);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(208, 35);
            this.buttonRemoveTask.TabIndex = 11;
            this.buttonRemoveTask.Text = "Remove Selected Task";
            this.buttonRemoveTask.UseVisualStyleBackColor = true;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(31, 466);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(208, 35);
            this.buttonAddTask.TabIndex = 6;
            this.buttonAddTask.Text = "Add New Task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // labelTaskDeadline
            // 
            this.labelTaskDeadline.AutoSize = true;
            this.labelTaskDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskDeadline.Location = new System.Drawing.Point(14, 324);
            this.labelTaskDeadline.Name = "labelTaskDeadline";
            this.labelTaskDeadline.Size = new System.Drawing.Size(114, 16);
            this.labelTaskDeadline.TabIndex = 10;
            this.labelTaskDeadline.Text = "Task Deadline:";
            // 
            // textBoxTaskDeadline
            // 
            this.textBoxTaskDeadline.Location = new System.Drawing.Point(134, 321);
            this.textBoxTaskDeadline.Name = "textBoxTaskDeadline";
            this.textBoxTaskDeadline.Size = new System.Drawing.Size(621, 22);
            this.textBoxTaskDeadline.TabIndex = 9;
            this.textBoxTaskDeadline.Text = "Task Deadline";
            this.textBoxTaskDeadline.TextChanged += new System.EventHandler(this.textBoxTaskDeadline_TextChanged);
            // 
            // richTextBoxTaskDescription
            // 
            this.richTextBoxTaskDescription.Location = new System.Drawing.Point(31, 99);
            this.richTextBoxTaskDescription.Name = "richTextBoxTaskDescription";
            this.richTextBoxTaskDescription.Size = new System.Drawing.Size(724, 201);
            this.richTextBoxTaskDescription.TabIndex = 8;
            this.richTextBoxTaskDescription.Text = "";
            this.richTextBoxTaskDescription.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(28, 80);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(113, 16);
            this.labelTaskDescription.TabIndex = 7;
            this.labelTaskDescription.Text = "Task Description:";
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTaskName.Location = new System.Drawing.Point(21, 29);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(92, 16);
            this.labelTaskName.TabIndex = 6;
            this.labelTaskName.Text = "Task Name:";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(116, 26);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(639, 22);
            this.textBoxTaskName.TabIndex = 0;
            this.textBoxTaskName.Text = "Task Name";
            this.textBoxTaskName.TextChanged += new System.EventHandler(this.textBoxTaskName_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelWorking);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Personal Organizer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelWorking.ResumeLayout(false);
            this.panelWorking.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWorking;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Label labelTasks;
        private System.Windows.Forms.Button buttonRemoveCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonEditTask;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Label labelTaskDeadline;
        private System.Windows.Forms.TextBox textBoxTaskDeadline;
        private System.Windows.Forms.RichTextBox richTextBoxTaskDescription;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Button buttonResetTask;
    }
}

