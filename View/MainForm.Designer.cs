namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewListEmployee = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zarplata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEmployee)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonAdd.Location = new System.Drawing.Point(20, 396);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add New";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRemove.Location = new System.Drawing.Point(115, 396);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonSearch.Location = new System.Drawing.Point(779, 396);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewListEmployee);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Directory";
            // 
            // dataGridViewListEmployee
            // 
            this.dataGridViewListEmployee.AllowUserToAddRows = false;
            this.dataGridViewListEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fname,
            this.Sname,
            this.Lname,
            this.Age,
            this.Phone,
            this.Profession,
            this.Zarplata});
            this.dataGridViewListEmployee.Location = new System.Drawing.Point(20, 25);
            this.dataGridViewListEmployee.Name = "dataGridViewListEmployee";
            this.dataGridViewListEmployee.ReadOnly = true;
            this.dataGridViewListEmployee.Size = new System.Drawing.Size(840, 370);
            this.dataGridViewListEmployee.TabIndex = 3;
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
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuMain});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(892, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuMain
            // 
            this.toolStripMenuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuOpen,
            this.toolStripMenuSave,
            this.toolStripMenuExit});
            this.toolStripMenuMain.Name = "toolStripMenuMain";
            this.toolStripMenuMain.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuMain.Text = "File";
            // 
            // toolStripMenuOpen
            // 
            this.toolStripMenuOpen.Name = "toolStripMenuOpen";
            this.toolStripMenuOpen.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuOpen.Text = "Open";
            this.toolStripMenuOpen.Click += new System.EventHandler(this.toolStripMenuOpen_Click);
            // 
            // toolStripMenuSave
            // 
            this.toolStripMenuSave.Name = "toolStripMenuSave";
            this.toolStripMenuSave.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuSave.Text = "Save";
            this.toolStripMenuSave.Click += new System.EventHandler(this.toolStripMenuSave_Click);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuExit.Text = "Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main Window";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListEmployee)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// Кнопка для открытия второй формы - формы добавления нового пользователя.
        /// </summary>
        private System.Windows.Forms.Button buttonAdd;
        /// <summary>
        /// Кнопка для удаления выбранной строки в таблице.
        /// </summary>
        private System.Windows.Forms.Button buttonRemove;
        /// <summary>
        /// Кнопка для открытия третьей формы - формы поиска.
        /// </summary>
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        /// <summary>
        /// Таблица юзеров.
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewListEmployee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuMain;
        /// <summary>
        /// Меню открытия файла и загрузки.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuOpen;
        /// <summary>
        /// Меню сохранения в файл.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSave;
        /// <summary>
        /// Аналог крестика - закрытие окна и программы.
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        /// <summary>
        /// Колонка ID.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        /// <summary>
        /// Колонка - Имя юзера.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        /// <summary>
        /// Колонка - фамилия юзера.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Sname;
        /// <summary>
        /// Колонка - отчество юзера.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Lname;
        /// <summary>
        /// Колонка - возраст юзера.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        /// <summary>
        /// Колонка - номер телефона юзера.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        /// <summary>
        /// Колонка - профессия юзера.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        /// <summary>
        /// Колонка - расчитанная зарплата юзера.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Zarplata;
    }
}

