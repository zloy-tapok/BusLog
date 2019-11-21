namespace View
{
    partial class SearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownZP = new System.Windows.Forms.NumericUpDown();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelZarplata = new System.Windows.Forms.Label();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zarplata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelId = new System.Windows.Forms.Label();
            this.labelProfession = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelSname = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.maskedTextBoxId = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxProfession = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAge = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLname = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSname = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFname = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownZP);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.labelZarplata);
            this.groupBox1.Controls.Add(this.dataGridViewSearch);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Controls.Add(this.labelProfession);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelAge);
            this.groupBox1.Controls.Add(this.labelLname);
            this.groupBox1.Controls.Add(this.labelSname);
            this.groupBox1.Controls.Add(this.labelFname);
            this.groupBox1.Controls.Add(this.maskedTextBoxId);
            this.groupBox1.Controls.Add(this.maskedTextBoxProfession);
            this.groupBox1.Controls.Add(this.maskedTextBoxPhone);
            this.groupBox1.Controls.Add(this.maskedTextBoxAge);
            this.groupBox1.Controls.Add(this.maskedTextBoxLname);
            this.groupBox1.Controls.Add(this.maskedTextBoxSname);
            this.groupBox1.Controls.Add(this.maskedTextBoxFname);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Data";
            // 
            // numericUpDownZP
            // 
            this.numericUpDownZP.DecimalPlaces = 2;
            this.numericUpDownZP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDownZP.Location = new System.Drawing.Point(659, 115);
            this.numericUpDownZP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownZP.Name = "numericUpDownZP";
            this.numericUpDownZP.Size = new System.Drawing.Size(124, 20);
            this.numericUpDownZP.TabIndex = 25;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonSearch.Location = new System.Drawing.Point(353, 37);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(116, 101);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonCancel.Location = new System.Drawing.Point(724, 384);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelZarplata
            // 
            this.labelZarplata.AutoSize = true;
            this.labelZarplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelZarplata.Location = new System.Drawing.Point(521, 125);
            this.labelZarplata.Name = "labelZarplata";
            this.labelZarplata.Size = new System.Drawing.Size(46, 13);
            this.labelZarplata.TabIndex = 17;
            this.labelZarplata.Text = "Zarplata";
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.AllowUserToDeleteRows = false;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fname,
            this.Sname,
            this.Lname,
            this.Age,
            this.Phone,
            this.Profession,
            this.Zarplata});
            this.dataGridViewSearch.Location = new System.Drawing.Point(-1, 155);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewSearch.Size = new System.Drawing.Size(800, 223);
            this.dataGridViewSearch.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Fname
            // 
            this.Fname.HeaderText = "First Name";
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            // 
            // Sname
            // 
            this.Sname.HeaderText = "Second Name";
            this.Sname.Name = "Sname";
            this.Sname.ReadOnly = true;
            // 
            // Lname
            // 
            this.Lname.HeaderText = "Last Name";
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Profession
            // 
            this.Profession.HeaderText = "Profession";
            this.Profession.Name = "Profession";
            this.Profession.ReadOnly = true;
            // 
            // Zarplata
            // 
            this.Zarplata.HeaderText = "Zarplata";
            this.Zarplata.Name = "Zarplata";
            this.Zarplata.ReadOnly = true;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelId.Location = new System.Drawing.Point(521, 100);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 13;
            this.labelId.Text = "Id";
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelProfession.Location = new System.Drawing.Point(521, 70);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(56, 13);
            this.labelProfession.TabIndex = 12;
            this.labelProfession.Text = "Profession";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPhone.Location = new System.Drawing.Point(521, 44);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Phone";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelAge.Location = new System.Drawing.Point(6, 122);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Age";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelLname.Location = new System.Drawing.Point(7, 96);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(58, 13);
            this.labelLname.TabIndex = 9;
            this.labelLname.Text = "Last Name";
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSname.Location = new System.Drawing.Point(7, 70);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(75, 13);
            this.labelSname.TabIndex = 8;
            this.labelSname.Text = "Second Name";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelFname.Location = new System.Drawing.Point(7, 44);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(57, 13);
            this.labelFname.TabIndex = 7;
            this.labelFname.Text = "First Name";
            // 
            // maskedTextBoxId
            // 
            this.maskedTextBoxId.BeepOnError = true;
            this.maskedTextBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxId.Location = new System.Drawing.Point(744, 89);
            this.maskedTextBoxId.Mask = "0000";
            this.maskedTextBoxId.Name = "maskedTextBoxId";
            this.maskedTextBoxId.PromptChar = ' ';
            this.maskedTextBoxId.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBoxId.TabIndex = 6;
            this.maskedTextBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxProfession
            // 
            this.maskedTextBoxProfession.BeepOnError = true;
            this.maskedTextBoxProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxProfession.Location = new System.Drawing.Point(659, 63);
            this.maskedTextBoxProfession.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBoxProfession.Name = "maskedTextBoxProfession";
            this.maskedTextBoxProfession.PromptChar = ' ';
            this.maskedTextBoxProfession.Size = new System.Drawing.Size(124, 20);
            this.maskedTextBoxProfession.TabIndex = 5;
            this.maskedTextBoxProfession.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BeepOnError = true;
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(695, 37);
            this.maskedTextBoxPhone.Mask = "000000000000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.PromptChar = ' ';
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBoxPhone.TabIndex = 4;
            this.maskedTextBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxAge
            // 
            this.maskedTextBoxAge.BeepOnError = true;
            this.maskedTextBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxAge.Location = new System.Drawing.Point(249, 114);
            this.maskedTextBoxAge.Mask = "000";
            this.maskedTextBoxAge.Name = "maskedTextBoxAge";
            this.maskedTextBoxAge.PromptChar = ' ';
            this.maskedTextBoxAge.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBoxAge.TabIndex = 3;
            this.maskedTextBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxAge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxLname
            // 
            this.maskedTextBoxLname.BeepOnError = true;
            this.maskedTextBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxLname.Location = new System.Drawing.Point(164, 89);
            this.maskedTextBoxLname.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBoxLname.Name = "maskedTextBoxLname";
            this.maskedTextBoxLname.PromptChar = ' ';
            this.maskedTextBoxLname.Size = new System.Drawing.Size(124, 20);
            this.maskedTextBoxLname.TabIndex = 2;
            this.maskedTextBoxLname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxSname
            // 
            this.maskedTextBoxSname.BeepOnError = true;
            this.maskedTextBoxSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxSname.Location = new System.Drawing.Point(164, 63);
            this.maskedTextBoxSname.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBoxSname.Name = "maskedTextBoxSname";
            this.maskedTextBoxSname.PromptChar = ' ';
            this.maskedTextBoxSname.Size = new System.Drawing.Size(124, 20);
            this.maskedTextBoxSname.TabIndex = 1;
            this.maskedTextBoxSname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxFname
            // 
            this.maskedTextBoxFname.BeepOnError = true;
            this.maskedTextBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxFname.Location = new System.Drawing.Point(164, 37);
            this.maskedTextBoxFname.Mask = "LLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBoxFname.Name = "maskedTextBoxFname";
            this.maskedTextBoxFname.PromptChar = ' ';
            this.maskedTextBoxFname.Size = new System.Drawing.Size(124, 20);
            this.maskedTextBoxFname.TabIndex = 0;
            this.maskedTextBoxFname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 449);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelSname;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxId;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProfession;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAge;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLname;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSname;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFname;
        private System.Windows.Forms.Label labelZarplata;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownZP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zarplata;
    }
}