namespace View
{
    partial class AddUserForm
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
            this.maskedTextBoxFname = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSname = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLname = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAge = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelSname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownWork1 = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxProfession = new System.Windows.Forms.MaskedTextBox();
            this.labelProfession = new System.Windows.Forms.Label();
            this.maskedTextBoxWork2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxWork3 = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelWork2 = new System.Windows.Forms.Label();
            this.labelWork3 = new System.Windows.Forms.Label();
            this.labelWork1 = new System.Windows.Forms.Label();
            this.radioButtonManagers = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkers = new System.Windows.Forms.RadioButton();
            this.radioButtonSpecialists = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWork1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxFname
            // 
            this.maskedTextBoxFname.BeepOnError = true;
            this.maskedTextBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxFname.Location = new System.Drawing.Point(137, 31);
            this.maskedTextBoxFname.Mask = "LLLLLLLLLLLLL";
            this.maskedTextBoxFname.Name = "maskedTextBoxFname";
            this.maskedTextBoxFname.PromptChar = ' ';
            this.maskedTextBoxFname.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBoxFname.TabIndex = 0;
            this.maskedTextBoxFname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxSname
            // 
            this.maskedTextBoxSname.BeepOnError = true;
            this.maskedTextBoxSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxSname.Location = new System.Drawing.Point(137, 57);
            this.maskedTextBoxSname.Mask = "LLLLLLLLLLLLL";
            this.maskedTextBoxSname.Name = "maskedTextBoxSname";
            this.maskedTextBoxSname.PromptChar = ' ';
            this.maskedTextBoxSname.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBoxSname.TabIndex = 1;
            this.maskedTextBoxSname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxLname
            // 
            this.maskedTextBoxLname.BeepOnError = true;
            this.maskedTextBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxLname.Location = new System.Drawing.Point(137, 83);
            this.maskedTextBoxLname.Mask = "LLLLLLLLLLLLL";
            this.maskedTextBoxLname.Name = "maskedTextBoxLname";
            this.maskedTextBoxLname.PromptChar = ' ';
            this.maskedTextBoxLname.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBoxLname.TabIndex = 2;
            this.maskedTextBoxLname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxAge
            // 
            this.maskedTextBoxAge.BeepOnError = true;
            this.maskedTextBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxAge.Location = new System.Drawing.Point(233, 110);
            this.maskedTextBoxAge.Mask = "000";
            this.maskedTextBoxAge.Name = "maskedTextBoxAge";
            this.maskedTextBoxAge.PromptChar = ' ';
            this.maskedTextBoxAge.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBoxAge.TabIndex = 3;
            this.maskedTextBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxAge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BeepOnError = true;
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(173, 137);
            this.maskedTextBoxPhone.Mask = "000000000000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.PromptChar = ' ';
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBoxPhone.TabIndex = 4;
            this.maskedTextBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelFname.Location = new System.Drawing.Point(34, 31);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(57, 13);
            this.labelFname.TabIndex = 14;
            this.labelFname.Text = "First Name";
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSname.Location = new System.Drawing.Point(34, 58);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(75, 13);
            this.labelSname.TabIndex = 15;
            this.labelSname.Text = "Second Name";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelLname.Location = new System.Drawing.Point(34, 84);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(58, 13);
            this.labelLname.TabIndex = 16;
            this.labelLname.Text = "Last Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelAge.Location = new System.Drawing.Point(34, 110);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 17;
            this.labelAge.Text = "Age";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPhone.Location = new System.Drawing.Point(34, 138);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Phone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownWork1);
            this.groupBox1.Controls.Add(this.maskedTextBoxProfession);
            this.groupBox1.Controls.Add(this.labelProfession);
            this.groupBox1.Controls.Add(this.maskedTextBoxWork2);
            this.groupBox1.Controls.Add(this.maskedTextBoxWork3);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonOk);
            this.groupBox1.Controls.Add(this.labelWork2);
            this.groupBox1.Controls.Add(this.labelWork3);
            this.groupBox1.Controls.Add(this.labelWork1);
            this.groupBox1.Controls.Add(this.radioButtonManagers);
            this.groupBox1.Controls.Add(this.radioButtonWorkers);
            this.groupBox1.Controls.Add(this.radioButtonSpecialists);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 228);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill out an employee card";
            // 
            // numericUpDownWork1
            // 
            this.numericUpDownWork1.DecimalPlaces = 2;
            this.numericUpDownWork1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numericUpDownWork1.InterceptArrowKeys = false;
            this.numericUpDownWork1.Location = new System.Drawing.Point(173, 52);
            this.numericUpDownWork1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownWork1.Name = "numericUpDownWork1";
            this.numericUpDownWork1.Size = new System.Drawing.Size(98, 20);
            this.numericUpDownWork1.TabIndex = 24;
            // 
            // maskedTextBoxProfession
            // 
            this.maskedTextBoxProfession.BeepOnError = true;
            this.maskedTextBoxProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxProfession.Location = new System.Drawing.Point(137, 26);
            this.maskedTextBoxProfession.Mask = "LLLLLLLLLLLLL";
            this.maskedTextBoxProfession.Name = "maskedTextBoxProfession";
            this.maskedTextBoxProfession.PromptChar = ' ';
            this.maskedTextBoxProfession.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBoxProfession.TabIndex = 5;
            this.maskedTextBoxProfession.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelProfession.Location = new System.Drawing.Point(34, 33);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(56, 13);
            this.labelProfession.TabIndex = 19;
            this.labelProfession.Text = "Profession";
            // 
            // maskedTextBoxWork2
            // 
            this.maskedTextBoxWork2.BeepOnError = true;
            this.maskedTextBoxWork2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxWork2.Location = new System.Drawing.Point(173, 79);
            this.maskedTextBoxWork2.Mask = "000000";
            this.maskedTextBoxWork2.Name = "maskedTextBoxWork2";
            this.maskedTextBoxWork2.PromptChar = ' ';
            this.maskedTextBoxWork2.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBoxWork2.TabIndex = 7;
            this.maskedTextBoxWork2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxWork2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // maskedTextBoxWork3
            // 
            this.maskedTextBoxWork3.BeepOnError = true;
            this.maskedTextBoxWork3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBoxWork3.Location = new System.Drawing.Point(173, 105);
            this.maskedTextBoxWork3.Mask = "000000";
            this.maskedTextBoxWork3.Name = "maskedTextBoxWork3";
            this.maskedTextBoxWork3.PromptChar = ' ';
            this.maskedTextBoxWork3.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBoxWork3.TabIndex = 8;
            this.maskedTextBoxWork3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxWork3.Visible = false;
            this.maskedTextBoxWork3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox_MouseClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonCancel.Location = new System.Drawing.Point(209, 194);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonOk.Location = new System.Drawing.Point(128, 194);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelWork2
            // 
            this.labelWork2.AutoSize = true;
            this.labelWork2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelWork2.Location = new System.Drawing.Point(34, 86);
            this.labelWork2.Name = "labelWork2";
            this.labelWork2.Size = new System.Drawing.Size(70, 13);
            this.labelWork2.TabIndex = 21;
            this.labelWork2.Text = "Number Hour";
            // 
            // labelWork3
            // 
            this.labelWork3.AutoSize = true;
            this.labelWork3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelWork3.Location = new System.Drawing.Point(34, 112);
            this.labelWork3.Name = "labelWork3";
            this.labelWork3.Size = new System.Drawing.Size(35, 13);
            this.labelWork3.TabIndex = 22;
            this.labelWork3.Text = "label8";
            this.labelWork3.Visible = false;
            // 
            // labelWork1
            // 
            this.labelWork1.AutoSize = true;
            this.labelWork1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelWork1.Location = new System.Drawing.Point(34, 60);
            this.labelWork1.Name = "labelWork1";
            this.labelWork1.Size = new System.Drawing.Size(57, 13);
            this.labelWork1.TabIndex = 20;
            this.labelWork1.Text = "Price Hour";
            // 
            // radioButtonManagers
            // 
            this.radioButtonManagers.AutoSize = true;
            this.radioButtonManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonManagers.Location = new System.Drawing.Point(37, 200);
            this.radioButtonManagers.Name = "radioButtonManagers";
            this.radioButtonManagers.Size = new System.Drawing.Size(72, 17);
            this.radioButtonManagers.TabIndex = 11;
            this.radioButtonManagers.Text = "Managers";
            this.radioButtonManagers.UseVisualStyleBackColor = true;
            this.radioButtonManagers.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonWorkers
            // 
            this.radioButtonWorkers.AutoSize = true;
            this.radioButtonWorkers.Checked = true;
            this.radioButtonWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonWorkers.Location = new System.Drawing.Point(37, 154);
            this.radioButtonWorkers.Name = "radioButtonWorkers";
            this.radioButtonWorkers.Size = new System.Drawing.Size(65, 17);
            this.radioButtonWorkers.TabIndex = 9;
            this.radioButtonWorkers.TabStop = true;
            this.radioButtonWorkers.Text = "Workers";
            this.radioButtonWorkers.UseVisualStyleBackColor = true;
            this.radioButtonWorkers.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSpecialists
            // 
            this.radioButtonSpecialists.AutoSize = true;
            this.radioButtonSpecialists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioButtonSpecialists.Location = new System.Drawing.Point(37, 177);
            this.radioButtonSpecialists.Name = "radioButtonSpecialists";
            this.radioButtonSpecialists.Size = new System.Drawing.Size(75, 17);
            this.radioButtonSpecialists.TabIndex = 10;
            this.radioButtonSpecialists.Text = "Specialists";
            this.radioButtonSpecialists.UseVisualStyleBackColor = true;
            this.radioButtonSpecialists.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelLname);
            this.groupBox2.Controls.Add(this.labelFname);
            this.groupBox2.Controls.Add(this.labelSname);
            this.groupBox2.Controls.Add(this.labelAge);
            this.groupBox2.Controls.Add(this.labelPhone);
            this.groupBox2.Controls.Add(this.maskedTextBoxFname);
            this.groupBox2.Controls.Add(this.maskedTextBoxSname);
            this.groupBox2.Controls.Add(this.maskedTextBoxPhone);
            this.groupBox2.Controls.Add(this.maskedTextBoxLname);
            this.groupBox2.Controls.Add(this.maskedTextBoxAge);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 163);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill out the person card";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(12, 407);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(297, 23);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.Text = "Generate Random Data";
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 438);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddUserForm";
            this.Text = "Add new employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWork1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

#endregion
        /// <summary>
        /// Текстовое поле для ввода Имени.
        /// Маска - только буквы.
        /// </summary>
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFname;
        /// <summary>
        /// Текстовое поле для ввода Фамилии. Маска - только буквы.
        /// </summary>
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSname;
        /// <summary>
        /// Текстовое поле для ввода Отчества. Маска - только буквы.
        /// </summary>
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLname;
        /// <summary>
        /// Текстовое поле для ввода Возраста. Маска - только цифры.
        /// </summary>
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAge;
        /// <summary>
        /// Текстовое поле для ввода Номера телефона. Маска - только цифры.
        /// </summary>
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        /// <summary>
        /// Название текстового поля для ввода Имени для пользователя.
        /// </summary>
        private System.Windows.Forms.Label labelFname;
        /// <summary>
        /// Название текстового поля для ввода Фамилии для пользователя.
        /// </summary>
        private System.Windows.Forms.Label labelSname;
        /// <summary>
        /// Название текстового поля для ввода Отчества для пользователя.
        /// </summary>
        private System.Windows.Forms.Label labelLname;
        /// <summary>
        /// Название текстового поля для ввода Возраста для пользователя.
        /// </summary>
        private System.Windows.Forms.Label labelAge;
        /// <summary>
        /// Название текстового поля для ввода Номера телефона для пользователя.
        /// </summary>
        private System.Windows.Forms.Label labelPhone;
        /// <summary>
        /// Группировка текстовых полей и заголовоков касаемых только личной части пользователя.
        /// Все свойства, которыми обладает класс Human.
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;
        /// <summary>
        ///Категория "Managers". Зарплата = Ставка(дневная) * Количество отработанных дней в месяц.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonManagers;
        /// <summary>
        /// Категория "Specialists". Зарплата = Оклад / Норма дней * Количество отработ. дней в месяц.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonSpecialists;
        /// <summary>
        /// Категория "Workers". Зарплата = Стоимость часа * Количество часов в месяц.
        /// </summary>
        private System.Windows.Forms.RadioButton radioButtonWorkers;
        /// <summary>
        /// Текстовое поле для ввода данных для расчета зарплаты.
        /// Маска - только цифры.
        /// </summary>
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWork2;
        /// <summary>
        /// Текстовое поле для ввода данных для расчета зарплаты.
        /// Маска - только цифры.
        /// Становится видимым для пользователя при включении radioButtonSpecialists.
        /// </summary>
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWork3;
        /// <summary>
        /// Название текстового поля для пользователя.
        /// Зависит от radioButton.
        /// </summary>
        private System.Windows.Forms.Label labelWork1;
        /// <summary>
        /// Название текстового поля для пользователя.
        /// Зависит от radioButton.
        /// </summary>
        private System.Windows.Forms.Label labelWork2;
        /// <summary>
        /// Название текстового поля для пользователя.
        /// Зависит от radioButton (видимый только при radioButtonSpecialists). 
        /// </summary>
        private System.Windows.Forms.Label labelWork3;
        /// <summary>
        /// Группировка полей и заголовков касаемых "профессиональной" части.
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox2;
        /// <summary>
        /// Кнопка отмены. Только закрывает форму.
        /// </summary>
        private System.Windows.Forms.Button buttonCancel;
        /// <summary>
        /// Кнопка OK.
        /// Запускает проверки, присвоение, расчет зарплаты и передает данные в основную форму.
        /// </summary>
        private System.Windows.Forms.Button buttonOk;
        /// <summary>
        /// Текстовое поле для ввода Профессии. Маска - только буквы.
        /// </summary>
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProfession;
        /// <summary>
        /// Название поля для пользователя.
        /// </summary>
        private System.Windows.Forms.Label labelProfession;
        /// <summary>
        /// Кнопка рандомного заполнения форм.
        /// Видна только в Debug версии.
        /// </summary>
        private System.Windows.Forms.Button buttonRandom;
        /// <summary>
        /// Цифровое поле для ввода decimal значений.
        /// </summary>
        private System.Windows.Forms.NumericUpDown numericUpDownWork1;
    }
}