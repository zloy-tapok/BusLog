using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма поиска по одному из свойств объекта.
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Новый пустой список сотрудников для дальнейших манипуляций.
        /// </summary>
        List<Employee> spisokSearch = new List<Employee>();

        /// <summary>
        /// Выводим таблицу-список найденных сотрудников.
        /// </summary>
        /// <param name="spisokSearchEmpl"></param>
        protected void DataGridViewSearch_Show(List<Employee> spisokSearchEmpl)
        {
            dataGridViewSearch.Rows.Clear();
            int i = 0;
            foreach (var item in spisokSearchEmpl)
            {
                item.Id = i;
                dataGridViewSearch.Rows.Add(spisokSearchEmpl[i].Id, spisokSearchEmpl[i].First_name, spisokSearchEmpl[i].Second_name,
                                                  spisokSearchEmpl[i].Last_name, spisokSearchEmpl[i].Age, spisokSearchEmpl[i].Phone,
                                                  spisokSearchEmpl[i].Profession, spisokSearchEmpl[i].Zarplata);
                i++;
            }
        }

        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// После загрузки формы заполняем список spisokSearch юзерами из основного списка (с главной формы).
        /// По нему будем проводить поиск.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;
            spisokSearch = mainForm.spisokEmployees;
        }

        #region Все maskedTextBox - установка курсора на начало.
        private void maskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            MaskedTextBox control = sender as MaskedTextBox;
            control.SelectionStart = 0;
        }
        #endregion

        /// <summary>
        /// Поиск через цикл-перебор.
        /// Сравнение всех текстовых форм и аналогичных свойств объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Employee> spisokSearchEmpl = new List<Employee>();
            spisokSearchEmpl.Clear();
          
            foreach (var item in spisokSearch)
            {
                if(maskedTextBoxFname.Text == item.First_name || 
                    maskedTextBoxSname.Text == item.Second_name || 
                    maskedTextBoxLname.Text == item.Last_name || 
                    maskedTextBoxAge.Text == Convert.ToString(item.Age) || 
                    maskedTextBoxPhone.Text == Convert.ToString(item.Phone) || 
                    maskedTextBoxProfession.Text == item.Profession  || 
                    numericUpDownZP.Text == Convert.ToString(item.Zarplata) || 
                    maskedTextBoxId.Text == Convert.ToString(item.Id))
                {                   
                    spisokSearchEmpl.Add(item);         
                }
              
            }
            if(spisokSearchEmpl.Count == 0)
            {
                MessageBox.Show("Nothing found!");
            }
            else
            {
                MessageBox.Show("Successful search!");
                DataGridViewSearch_Show(spisokSearchEmpl);
            }
        }

        
        /// <summary>
        /// Событие "Нажатие на кнопку "Cancel" только закрывает форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
