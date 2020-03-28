namespace HRDepartment
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
            this.groupBoxEmpInfo = new System.Windows.Forms.GroupBox();
            this.listBoxEmp = new System.Windows.Forms.ListBox();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemEmp = new System.Windows.Forms.Button();
            this.buttonRemDep = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAddEmp = new System.Windows.Forms.Button();
            this.buttonAddDep = new System.Windows.Forms.Button();
            this.groupBoxPersonalInfo = new System.Windows.Forms.GroupBox();
            this.rTextBoxSkills = new System.Windows.Forms.RichTextBox();
            this.labelSkills = new System.Windows.Forms.Label();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxSocMedia = new System.Windows.Forms.TextBox();
            this.labelSocMedia = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.dateTimePickerBday = new System.Windows.Forms.DateTimePicker();
            this.labelBday = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.groupBoxEmpInfo.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.groupBoxPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmpInfo
            // 
            this.groupBoxEmpInfo.Controls.Add(this.listBoxEmp);
            this.groupBoxEmpInfo.Controls.Add(this.comboBoxDep);
            this.groupBoxEmpInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxEmpInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEmpInfo.Name = "groupBoxEmpInfo";
            this.groupBoxEmpInfo.Size = new System.Drawing.Size(200, 613);
            this.groupBoxEmpInfo.TabIndex = 0;
            this.groupBoxEmpInfo.TabStop = false;
            this.groupBoxEmpInfo.Text = "Employments Info";
            // 
            // listBoxEmp
            // 
            this.listBoxEmp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxEmp.FormattingEnabled = true;
            this.listBoxEmp.ItemHeight = 16;
            this.listBoxEmp.Location = new System.Drawing.Point(3, 62);
            this.listBoxEmp.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.listBoxEmp.Name = "listBoxEmp";
            this.listBoxEmp.Size = new System.Drawing.Size(194, 548);
            this.listBoxEmp.TabIndex = 1;
            this.listBoxEmp.SelectedIndexChanged += new System.EventHandler(this.listBoxEmp_SelectedIndexChanged);
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(3, 18);
            this.comboBoxDep.Margin = new System.Windows.Forms.Padding(10);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(194, 24);
            this.comboBoxDep.TabIndex = 0;
            this.comboBoxDep.SelectedIndexChanged += new System.EventHandler(this.comboBoxDep_SelectedIndexChanged);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonSave);
            this.groupBoxControls.Controls.Add(this.buttonRemEmp);
            this.groupBoxControls.Controls.Add(this.buttonRemDep);
            this.groupBoxControls.Controls.Add(this.buttonReset);
            this.groupBoxControls.Controls.Add(this.buttonAddEmp);
            this.groupBoxControls.Controls.Add(this.buttonAddDep);
            this.groupBoxControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxControls.Location = new System.Drawing.Point(200, 513);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(441, 100);
            this.groupBoxControls.TabIndex = 1;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(354, 65);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemEmp
            // 
            this.buttonRemEmp.Location = new System.Drawing.Point(174, 65);
            this.buttonRemEmp.Name = "buttonRemEmp";
            this.buttonRemEmp.Size = new System.Drawing.Size(158, 23);
            this.buttonRemEmp.TabIndex = 4;
            this.buttonRemEmp.Text = "Remove Employee";
            this.buttonRemEmp.UseVisualStyleBackColor = true;
            this.buttonRemEmp.Click += new System.EventHandler(this.buttonRemEmp_Click);
            // 
            // buttonRemDep
            // 
            this.buttonRemDep.Location = new System.Drawing.Point(10, 65);
            this.buttonRemDep.Name = "buttonRemDep";
            this.buttonRemDep.Size = new System.Drawing.Size(158, 23);
            this.buttonRemDep.TabIndex = 3;
            this.buttonRemDep.Text = "Remove Department";
            this.buttonRemDep.UseVisualStyleBackColor = true;
            this.buttonRemDep.Click += new System.EventHandler(this.buttonRemDep_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(354, 28);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.Location = new System.Drawing.Point(174, 28);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.Size = new System.Drawing.Size(158, 23);
            this.buttonAddEmp.TabIndex = 1;
            this.buttonAddEmp.Text = "Add Employee";
            this.buttonAddEmp.UseVisualStyleBackColor = true;
            this.buttonAddEmp.Click += new System.EventHandler(this.buttonAddEmp_Click);
            // 
            // buttonAddDep
            // 
            this.buttonAddDep.Location = new System.Drawing.Point(10, 28);
            this.buttonAddDep.Name = "buttonAddDep";
            this.buttonAddDep.Size = new System.Drawing.Size(158, 23);
            this.buttonAddDep.TabIndex = 0;
            this.buttonAddDep.Text = "Add Department";
            this.buttonAddDep.UseVisualStyleBackColor = true;
            this.buttonAddDep.Click += new System.EventHandler(this.buttonAddDep_Click);
            // 
            // groupBoxPersonalInfo
            // 
            this.groupBoxPersonalInfo.Controls.Add(this.rTextBoxSkills);
            this.groupBoxPersonalInfo.Controls.Add(this.labelSkills);
            this.groupBoxPersonalInfo.Controls.Add(this.numericUpDownSalary);
            this.groupBoxPersonalInfo.Controls.Add(this.labelSalary);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxPosition);
            this.groupBoxPersonalInfo.Controls.Add(this.labelPosition);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxSocMedia);
            this.groupBoxPersonalInfo.Controls.Add(this.labelSocMedia);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxPhone);
            this.groupBoxPersonalInfo.Controls.Add(this.labelPhone);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxEmail);
            this.groupBoxPersonalInfo.Controls.Add(this.labelEmail);
            this.groupBoxPersonalInfo.Controls.Add(this.dateTimePickerBday);
            this.groupBoxPersonalInfo.Controls.Add(this.labelBday);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxFullName);
            this.groupBoxPersonalInfo.Controls.Add(this.labelFullName);
            this.groupBoxPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPersonalInfo.Location = new System.Drawing.Point(200, 0);
            this.groupBoxPersonalInfo.Name = "groupBoxPersonalInfo";
            this.groupBoxPersonalInfo.Size = new System.Drawing.Size(441, 513);
            this.groupBoxPersonalInfo.TabIndex = 2;
            this.groupBoxPersonalInfo.TabStop = false;
            this.groupBoxPersonalInfo.Text = "Personal Info";
            this.groupBoxPersonalInfo.Enter += new System.EventHandler(this.groupBoxPersonalInfo_Enter);
            // 
            // rTextBoxSkills
            // 
            this.rTextBoxSkills.Location = new System.Drawing.Point(107, 442);
            this.rTextBoxSkills.Name = "rTextBoxSkills";
            this.rTextBoxSkills.Size = new System.Drawing.Size(302, 65);
            this.rTextBoxSkills.TabIndex = 15;
            this.rTextBoxSkills.Text = "";
            // 
            // labelSkills
            // 
            this.labelSkills.AutoSize = true;
            this.labelSkills.Location = new System.Drawing.Point(7, 442);
            this.labelSkills.Name = "labelSkills";
            this.labelSkills.Size = new System.Drawing.Size(40, 16);
            this.labelSkills.TabIndex = 14;
            this.labelSkills.Text = "Skills";
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Location = new System.Drawing.Point(146, 376);
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownSalary.TabIndex = 13;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(75, 376);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(47, 16);
            this.labelSalary.TabIndex = 12;
            this.labelSalary.Text = "Salary";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(107, 330);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(302, 22);
            this.textBoxPosition.TabIndex = 11;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(7, 330);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(56, 16);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "Position";
            // 
            // textBoxSocMedia
            // 
            this.textBoxSocMedia.Location = new System.Drawing.Point(107, 272);
            this.textBoxSocMedia.Name = "textBoxSocMedia";
            this.textBoxSocMedia.Size = new System.Drawing.Size(302, 22);
            this.textBoxSocMedia.TabIndex = 9;
            // 
            // labelSocMedia
            // 
            this.labelSocMedia.AutoSize = true;
            this.labelSocMedia.Location = new System.Drawing.Point(7, 272);
            this.labelSocMedia.Name = "labelSocMedia";
            this.labelSocMedia.Size = new System.Drawing.Size(87, 16);
            this.labelSocMedia.TabIndex = 8;
            this.labelSocMedia.Text = "Social Media";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(107, 211);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(302, 22);
            this.textBoxPhone.TabIndex = 7;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(7, 211);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(47, 16);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(107, 157);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(302, 22);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(7, 157);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 16);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // dateTimePickerBday
            // 
            this.dateTimePickerBday.Location = new System.Drawing.Point(146, 98);
            this.dateTimePickerBday.Name = "dateTimePickerBday";
            this.dateTimePickerBday.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBday.TabIndex = 3;
            // 
            // labelBday
            // 
            this.labelBday.AutoSize = true;
            this.labelBday.Location = new System.Drawing.Point(75, 98);
            this.labelBday.Name = "labelBday";
            this.labelBday.Size = new System.Drawing.Size(40, 16);
            this.labelBday.TabIndex = 2;
            this.labelBday.Text = "Bday";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(107, 41);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(302, 22);
            this.textBoxFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(7, 41);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(69, 16);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full Name";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 613);
            this.Controls.Add(this.groupBoxPersonalInfo);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxEmpInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Hr Department Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEmpInfo.ResumeLayout(false);
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxPersonalInfo.ResumeLayout(false);
            this.groupBoxPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmpInfo;
        private System.Windows.Forms.ListBox listBoxEmp;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.GroupBox groupBoxPersonalInfo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerBday;
        private System.Windows.Forms.Label labelBday;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemEmp;
        private System.Windows.Forms.Button buttonRemDep;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAddEmp;
        private System.Windows.Forms.Button buttonAddDep;
        private System.Windows.Forms.RichTextBox rTextBoxSkills;
        private System.Windows.Forms.Label labelSkills;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxSocMedia;
        private System.Windows.Forms.Label labelSocMedia;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}

