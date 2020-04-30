namespace AsyncDemo
{
    partial class MainForm
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
            this.gbAsyncFirst = new System.Windows.Forms.GroupBox();
            this.rtbAsyncOutputFirst = new System.Windows.Forms.RichTextBox();
            this.gbAsyncOpSecond = new System.Windows.Forms.GroupBox();
            this.rtbAsyncOutputSecond = new System.Windows.Forms.RichTextBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.bReset = new System.Windows.Forms.Button();
            this.bOp2 = new System.Windows.Forms.Button();
            this.bOp1 = new System.Windows.Forms.Button();
            this.pbOp1 = new System.Windows.Forms.ProgressBar();
            this.pbOp2 = new System.Windows.Forms.ProgressBar();
            this.gbAsyncFirst.SuspendLayout();
            this.gbAsyncOpSecond.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAsyncFirst
            // 
            this.gbAsyncFirst.Controls.Add(this.pbOp1);
            this.gbAsyncFirst.Controls.Add(this.rtbAsyncOutputFirst);
            this.gbAsyncFirst.Location = new System.Drawing.Point(12, 12);
            this.gbAsyncFirst.Name = "gbAsyncFirst";
            this.gbAsyncFirst.Size = new System.Drawing.Size(312, 283);
            this.gbAsyncFirst.TabIndex = 0;
            this.gbAsyncFirst.TabStop = false;
            this.gbAsyncFirst.Text = "Async Op1";
            // 
            // rtbAsyncOutputFirst
            // 
            this.rtbAsyncOutputFirst.Location = new System.Drawing.Point(7, 20);
            this.rtbAsyncOutputFirst.Name = "rtbAsyncOutputFirst";
            this.rtbAsyncOutputFirst.Size = new System.Drawing.Size(299, 229);
            this.rtbAsyncOutputFirst.TabIndex = 0;
            this.rtbAsyncOutputFirst.Text = "";
            // 
            // gbAsyncOpSecond
            // 
            this.gbAsyncOpSecond.Controls.Add(this.pbOp2);
            this.gbAsyncOpSecond.Controls.Add(this.rtbAsyncOutputSecond);
            this.gbAsyncOpSecond.Location = new System.Drawing.Point(357, 12);
            this.gbAsyncOpSecond.Name = "gbAsyncOpSecond";
            this.gbAsyncOpSecond.Size = new System.Drawing.Size(312, 283);
            this.gbAsyncOpSecond.TabIndex = 1;
            this.gbAsyncOpSecond.TabStop = false;
            this.gbAsyncOpSecond.Text = "Async Op2";
            // 
            // rtbAsyncOutputSecond
            // 
            this.rtbAsyncOutputSecond.Location = new System.Drawing.Point(7, 20);
            this.rtbAsyncOutputSecond.Name = "rtbAsyncOutputSecond";
            this.rtbAsyncOutputSecond.Size = new System.Drawing.Size(299, 229);
            this.rtbAsyncOutputSecond.TabIndex = 0;
            this.rtbAsyncOutputSecond.Text = "";
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.bReset);
            this.gbControls.Controls.Add(this.bOp2);
            this.gbControls.Controls.Add(this.bOp1);
            this.gbControls.Location = new System.Drawing.Point(12, 313);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(657, 64);
            this.gbControls.TabIndex = 2;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(421, 19);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(185, 23);
            this.bReset.TabIndex = 0;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bOp2
            // 
            this.bOp2.Location = new System.Drawing.Point(230, 19);
            this.bOp2.Name = "bOp2";
            this.bOp2.Size = new System.Drawing.Size(185, 23);
            this.bOp2.TabIndex = 0;
            this.bOp2.Text = "Second Operation";
            this.bOp2.UseVisualStyleBackColor = true;
            this.bOp2.Click += new System.EventHandler(this.bOp2_Click);
            // 
            // bOp1
            // 
            this.bOp1.Location = new System.Drawing.Point(39, 20);
            this.bOp1.Name = "bOp1";
            this.bOp1.Size = new System.Drawing.Size(185, 23);
            this.bOp1.TabIndex = 0;
            this.bOp1.Text = "First Operation";
            this.bOp1.UseVisualStyleBackColor = true;
            this.bOp1.Click += new System.EventHandler(this.bOp1_Click);
            // 
            // pbOp1
            // 
            this.pbOp1.Location = new System.Drawing.Point(7, 256);
            this.pbOp1.Name = "pbOp1";
            this.pbOp1.Size = new System.Drawing.Size(299, 23);
            this.pbOp1.TabIndex = 1;
            // 
            // pbOp2
            // 
            this.pbOp2.Location = new System.Drawing.Point(7, 254);
            this.pbOp2.Name = "pbOp2";
            this.pbOp2.Size = new System.Drawing.Size(299, 23);
            this.pbOp2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbAsyncOpSecond);
            this.Controls.Add(this.gbAsyncFirst);
            this.Name = "MainForm";
            this.Text = "Async Demo";
            this.gbAsyncFirst.ResumeLayout(false);
            this.gbAsyncOpSecond.ResumeLayout(false);
            this.gbControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAsyncFirst;
        private System.Windows.Forms.RichTextBox rtbAsyncOutputFirst;
        private System.Windows.Forms.GroupBox gbAsyncOpSecond;
        private System.Windows.Forms.RichTextBox rtbAsyncOutputSecond;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bOp2;
        private System.Windows.Forms.Button bOp1;
        private System.Windows.Forms.ProgressBar pbOp1;
        private System.Windows.Forms.ProgressBar pbOp2;
    }
}

