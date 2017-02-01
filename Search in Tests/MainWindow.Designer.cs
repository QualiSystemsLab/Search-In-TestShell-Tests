namespace Search_in_Tests
{
    partial class MainWindow
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
            this.localChk = new System.Windows.Forms.CheckBox();
            this.sharedChk = new System.Windows.Forms.CheckBox();
            this.searchString = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.methodChk = new System.Windows.Forms.CheckBox();
            this.nameChk = new System.Windows.Forms.CheckBox();
            this.stepsDscrChk = new System.Windows.Forms.CheckBox();
            this.varDscrChk = new System.Windows.Forms.CheckBox();
            this.stepsChk = new System.Windows.Forms.CheckBox();
            this.varChk = new System.Windows.Forms.CheckBox();
            this.descriptionChk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.localRoot = new System.Windows.Forms.TextBox();
            this.browseLocal = new System.Windows.Forms.Button();
            this.localSubfolders = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.exportBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // localChk
            // 
            this.localChk.AutoSize = true;
            this.localChk.Checked = true;
            this.localChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.localChk.Location = new System.Drawing.Point(24, 23);
            this.localChk.Margin = new System.Windows.Forms.Padding(6);
            this.localChk.Name = "localChk";
            this.localChk.Size = new System.Drawing.Size(83, 29);
            this.localChk.TabIndex = 0;
            this.localChk.Text = "Local";
            this.localChk.UseVisualStyleBackColor = true;
            // 
            // sharedChk
            // 
            this.sharedChk.AutoSize = true;
            this.sharedChk.Enabled = false;
            this.sharedChk.Location = new System.Drawing.Point(24, 75);
            this.sharedChk.Margin = new System.Windows.Forms.Padding(6);
            this.sharedChk.Name = "sharedChk";
            this.sharedChk.Size = new System.Drawing.Size(100, 29);
            this.sharedChk.TabIndex = 1;
            this.sharedChk.Text = "Shared";
            this.sharedChk.UseVisualStyleBackColor = true;
            this.sharedChk.Visible = false;
            // 
            // searchString
            // 
            this.searchString.Location = new System.Drawing.Point(28, 152);
            this.searchString.Margin = new System.Windows.Forms.Padding(6);
            this.searchString.Name = "searchString";
            this.searchString.Size = new System.Drawing.Size(1218, 31);
            this.searchString.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 371);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 319);
            this.dataGridView1.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(1008, 283);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(242, 77);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.methodChk);
            this.groupBox1.Controls.Add(this.nameChk);
            this.groupBox1.Controls.Add(this.stepsDscrChk);
            this.groupBox1.Controls.Add(this.varDscrChk);
            this.groupBox1.Controls.Add(this.stepsChk);
            this.groupBox1.Controls.Add(this.varChk);
            this.groupBox1.Controls.Add(this.descriptionChk);
            this.groupBox1.Location = new System.Drawing.Point(24, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(964, 158);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search In";
            // 
            // methodChk
            // 
            this.methodChk.AutoSize = true;
            this.methodChk.Location = new System.Drawing.Point(736, 44);
            this.methodChk.Margin = new System.Windows.Forms.Padding(6);
            this.methodChk.Name = "methodChk";
            this.methodChk.Size = new System.Drawing.Size(176, 29);
            this.methodChk.TabIndex = 17;
            this.methodChk.Text = "Method Names";
            this.methodChk.UseVisualStyleBackColor = true;
            // 
            // nameChk
            // 
            this.nameChk.AutoSize = true;
            this.nameChk.Location = new System.Drawing.Point(12, 44);
            this.nameChk.Margin = new System.Windows.Forms.Padding(6);
            this.nameChk.Name = "nameChk";
            this.nameChk.Size = new System.Drawing.Size(87, 29);
            this.nameChk.TabIndex = 16;
            this.nameChk.Text = "Name";
            this.nameChk.UseVisualStyleBackColor = true;
            // 
            // stepsDscrChk
            // 
            this.stepsDscrChk.AutoSize = true;
            this.stepsDscrChk.Location = new System.Drawing.Point(478, 88);
            this.stepsDscrChk.Margin = new System.Windows.Forms.Padding(6);
            this.stepsDscrChk.Name = "stepsDscrChk";
            this.stepsDscrChk.Size = new System.Drawing.Size(189, 29);
            this.stepsDscrChk.TabIndex = 15;
            this.stepsDscrChk.Text = "Step Description";
            this.stepsDscrChk.UseVisualStyleBackColor = true;
            // 
            // varDscrChk
            // 
            this.varDscrChk.AutoSize = true;
            this.varDscrChk.Location = new System.Drawing.Point(184, 88);
            this.varDscrChk.Margin = new System.Windows.Forms.Padding(6);
            this.varDscrChk.Name = "varDscrChk";
            this.varDscrChk.Size = new System.Drawing.Size(224, 29);
            this.varDscrChk.TabIndex = 14;
            this.varDscrChk.Text = "Variable Description";
            this.varDscrChk.UseVisualStyleBackColor = true;
            // 
            // stepsChk
            // 
            this.stepsChk.AutoSize = true;
            this.stepsChk.Location = new System.Drawing.Point(478, 44);
            this.stepsChk.Margin = new System.Windows.Forms.Padding(6);
            this.stepsChk.Name = "stepsChk";
            this.stepsChk.Size = new System.Drawing.Size(86, 29);
            this.stepsChk.TabIndex = 13;
            this.stepsChk.Text = "Steps";
            this.stepsChk.UseVisualStyleBackColor = true;
            // 
            // varChk
            // 
            this.varChk.AutoSize = true;
            this.varChk.Location = new System.Drawing.Point(184, 44);
            this.varChk.Margin = new System.Windows.Forms.Padding(6);
            this.varChk.Name = "varChk";
            this.varChk.Size = new System.Drawing.Size(121, 29);
            this.varChk.TabIndex = 12;
            this.varChk.Text = "Variables";
            this.varChk.UseVisualStyleBackColor = true;
            // 
            // descriptionChk
            // 
            this.descriptionChk.AutoSize = true;
            this.descriptionChk.Location = new System.Drawing.Point(12, 88);
            this.descriptionChk.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionChk.Name = "descriptionChk";
            this.descriptionChk.Size = new System.Drawing.Size(139, 29);
            this.descriptionChk.TabIndex = 11;
            this.descriptionChk.Text = "Description";
            this.descriptionChk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Text to search";
            // 
            // localRoot
            // 
            this.localRoot.Location = new System.Drawing.Point(140, 21);
            this.localRoot.Margin = new System.Windows.Forms.Padding(6);
            this.localRoot.Name = "localRoot";
            this.localRoot.Size = new System.Drawing.Size(468, 31);
            this.localRoot.TabIndex = 13;
            // 
            // browseLocal
            // 
            this.browseLocal.Location = new System.Drawing.Point(620, 17);
            this.browseLocal.Margin = new System.Windows.Forms.Padding(6);
            this.browseLocal.Name = "browseLocal";
            this.browseLocal.Size = new System.Drawing.Size(128, 44);
            this.browseLocal.TabIndex = 14;
            this.browseLocal.Text = "Browse";
            this.browseLocal.UseVisualStyleBackColor = true;
            this.browseLocal.Click += new System.EventHandler(this.browseLocal_Click);
            // 
            // localSubfolders
            // 
            this.localSubfolders.AutoSize = true;
            this.localSubfolders.Location = new System.Drawing.Point(760, 27);
            this.localSubfolders.Margin = new System.Windows.Forms.Padding(6);
            this.localSubfolders.Name = "localSubfolders";
            this.localSubfolders.Size = new System.Drawing.Size(209, 29);
            this.localSubfolders.TabIndex = 15;
            this.localSubfolders.Text = "Include Subfolders";
            this.localSubfolders.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(760, 77);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(209, 29);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Include Subfolders";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(620, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(140, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(468, 31);
            this.textBox2.TabIndex = 16;
            this.textBox2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(24, 702);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(982, 44);
            this.progressBar1.TabIndex = 19;
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBtn.Enabled = false;
            this.exportBtn.Location = new System.Drawing.Point(1018, 702);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(6);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(230, 44);
            this.exportBtn.TabIndex = 20;
            this.exportBtn.Text = "Save Results";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 761);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.localSubfolders);
            this.Controls.Add(this.browseLocal);
            this.Controls.Add(this.localRoot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchString);
            this.Controls.Add(this.sharedChk);
            this.Controls.Add(this.localChk);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1292, 800);
            this.Name = "MainWindow";
            this.Text = "Search in Tests";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox localChk;
        private System.Windows.Forms.CheckBox sharedChk;
        private System.Windows.Forms.TextBox searchString;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox nameChk;
        private System.Windows.Forms.CheckBox stepsDscrChk;
        private System.Windows.Forms.CheckBox varDscrChk;
        private System.Windows.Forms.CheckBox stepsChk;
        private System.Windows.Forms.CheckBox varChk;
        private System.Windows.Forms.CheckBox descriptionChk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox localRoot;
        private System.Windows.Forms.Button browseLocal;
        private System.Windows.Forms.CheckBox localSubfolders;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox methodChk;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

