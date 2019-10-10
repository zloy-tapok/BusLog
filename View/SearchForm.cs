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
        List<Employee> spisokEmployees = new List<Employee>();
        /// <summary>
        /// Список найденных сотрудников.
        /// </summary>

        /// <summary>
        /// Метод поиска - вся логика здесь.
        /// </summary>
        //private void Search(string searchText, Employee property)
        //{
            
        //    List<Employee> spisokSearchEmpl = new List<Employee>();
            
        //    foreach (var item in spisokEmployees)
        //    {
        //        if (searchText == item.property;
        //        {

        //            spisokSearchEmpl.Add(new Employee());
        //            int i = 0;
        //            spisokSearchEmpl[i] = item;
        //            i++;
        //        }

        //    }
        //    if (spisokSearchEmpl.Count == 0)
        //    {
        //        MessageBox.Show("Ничего не найдено");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Успешный поиск!");
        //        BindingSource bs = new BindingSource();
        //        bs.DataSource = spisokSearchEmpl;
        //        dataGridViewSearch.DataSource = bs;
        //    }
        //}

        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При загрузке формы происходит десериализация списка (если файл не пустой).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            spisokEmployees = Employee.DoDeserial();
        }

        #region Все maskedTextBox - установка курсора на начало.
        private void maskedTextBoxFname_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxFname.SelectionStart = 0;
        }

        private void maskedTextBoxSname_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxSname.SelectionStart = 0;
        }

        private void maskedTextBoxLname_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxLname.SelectionStart = 0;
        }

        private void maskedTextBoxAge_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxAge.SelectionStart = 0;
        }

        private void maskedTextBoxPhone_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxPhone.SelectionStart = 0;
        }

        private void maskedTextBoxProfession_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxProfession.SelectionStart = 0;
        }

        private void maskedTextBoxId_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxId.SelectionStart = 0;
        }

        private void maskedTextBoxZarplata_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxZarplata.SelectionStart = 0;
        }
        #endregion


        /// <summary>
        /// При каждой активации основной формы, обновляется поисковый список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Activated(object sender, EventArgs e)
        {
            
        }


        private void buttonSearchFname_Click(object sender, EventArgs e)
        {
            List<Employee> spisokSearchEmpl = new List<Employee>();
            foreach (var item in spisokEmployees)
            {
                if(maskedTextBoxFname.Text == item.Fname)
                {
                    
                    spisokSearchEmpl.Add(new Employee());
                    int i = 0;
                    spisokSearchEmpl[i] = item;
                    i++;
                }
              
            }
            if(spisokSearchEmpl.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else
            {
                MessageBox.Show("Успешный поиск!");
                BindingSource bs = new BindingSource();
                bs.DataSource = spisokSearchEmpl;
                dataGridViewSearch.DataSource = bs;
            }
        }

      

        private void buttonSearchSname_Click(object sender, EventArgs e)
        {
            List<Employee> spisokSearchEmpl = new List<Employee>();
            foreach (var item in spisokEmployees)
            {
                if (maskedTextBoxSname.Text == item.Sname)
                {
                    spisokSearchEmpl.Add(new Employee());
                    int i = 0;
                    spisokSearchEmpl[i] = item;
                    i++;
                }

            }
            if (spisokSearchEmpl.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else
            {
                MessageBox.Show("Успешный поиск!");
             
                BindingSource bs = new BindingSource();
                bs.DataSource = spisokSearchEmpl;
                dataGridViewSearch.DataSource = bs;
            }
        }

        private void buttonSearchLname_Click(object sender, EventArgs e)
        {
            List<Employee> spisokSearchEmpl = new List<Employee>();
            foreach (var item in spisokEmployees)
            {
                if (maskedTextBoxLname.Text == item.Lname)
                {
                    spisokSearchEmpl.Add(new Employee());
                    int i = 0;
                    spisokSearchEmpl[i] = item;
                    i++;
                }

            }
            if (spisokSearchEmpl.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else
            {
                MessageBox.Show("Успешный поиск!");
           
                BindingSource bs = new BindingSource();
                bs.DataSource = spisokSearchEmpl;
                dataGridViewSearch.DataSource = bs;
            }
        }

        private void buttonSearchAge_Click(object sender, EventArgs e)
        {
            List<Employee> spisokSearchEmpl = new List<Employee>();
            foreach (var item in spisokEmployees)
            {
                if (maskedTextBoxAge.Text == Convert.ToString(item.Age))
                {
                    spisokSearchEmpl.Add(new Employee());
                    int i = 0;
                    spisokSearchEmpl[i] = item;
                    i++;
                }

            }
            if (spisokSearchEmpl.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else
            {
                MessageBox.Show("Успешный поиск!");
          
                BindingSource bs = new BindingSource();
                bs.DataSource = spisokSearchEmpl;
                dataGridViewSearch.DataSource = bs;
            }
        }

        private void buttonSearchPhone_Click(object sender, EventArgs e)
        {
            List<Employee> spisokSearchEmpl = new List<Employee>();
            foreach (var item in spisokEmployees)
            {
                if (maskedTextBoxPhone.Text == Convert.ToString(item.Phone))
                {
                    spisokSearchEmpl.Add(new Employee());
                    int i = 0;
                    spisokSearchEmpl[i] = item;
                    i++;
                }

            }
            if (spisokSearchEmpl.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else
            {
                MessageBox.Show("Успешный поиск!");
               
                BindingSource bs = new BindingSource();
                bs.DataSource = spisokSearchEmpl;
                dataGridViewSearch.DataSource = bs;
            }
        }

        private void buttonSearchProf_Click(object sender, EventArgs e)
        {
            List<Employee> spisokSearchEmpl = new List<Employee>();
            foreach (var item in spisokEmployees)
            {
                if (maskedTextBoxProfession.Text == item.Profession)
                {
                    spisokSearchEmpl.Add(new Employee());
                    int i = 0;
                    spisokSearchEmpl[i] = item;
                    i++;
                }

            }
            if (spisokSearchEmpl.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else
            {
                MessageBox.Show("Успешный поиск!");
               
                BindingSource bs = new BindingSource();
                bs.DataSource = spisokSearchEmpl;
                dataGridViewSearch.DataSource = bs;
            }
        }

        private void buttonSearchId_Click(object sender, EventArgs e)
        {
            List<Employee> spisokSearchEmpl = new List<Employee>();
            foreach (var item in spisokEmployees)
            {
                if (maskedTextBoxId.Text ==Convert.ToString(item.Id))
                {
                    spisokSearchEmpl.Add(new Employee());
                    int i = 0;
                    spisokSearchEmpl[i] = item;
                    i++;
                }

            }
            if (spisokSearchEmpl.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else
            {
                MessageBox.Show("Успешный поиск!");
              
                BindingSource bs = new BindingSource();
                bs.DataSource = spisokSearchEmpl;
                dataGridViewSearch.DataSource = bs;
            }
        }

        private void buttonSearchZP_Click(object sender, EventArgs e)
        {
            List<Employee> spisokSearchEmpl = new List<Employee>();
            foreach (var item in spisokEmployees)
            {
                if (maskedTextBoxZarplata.Text == Convert.ToString(item.Zarplata))
                {
                    spisokSearchEmpl.Add(new Employee());
                    int i = 0;
                    spisokSearchEmpl[i] = item;
                    i++;
                }

            }
            if (spisokSearchEmpl.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else
            {
                MessageBox.Show("Успешный поиск!");
                BindingSource bs = new BindingSource();
                bs.DataSource = spisokSearchEmpl;
                dataGridViewSearch.DataSource = bs;
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
