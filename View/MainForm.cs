using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Первая, основная форма, где выводятся данные по сотрудникам.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Новый пустой список сотрудников для дальнейших манипуляций.
        /// </summary>
        List<Employee> spisokEmployees = new List<Employee>();
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При каждой активации основной формы, обновляется список сотрудников из файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Activated(object sender, EventArgs e)
        {
           
            spisokEmployees = Employee.DoDeserial();
            BindingSource bs = new BindingSource();
            bs.DataSource = spisokEmployees;
            dataGridViewListEmployee.DataSource = bs;

            

        }
        /// <summary>
        /// Событие "Нажатие на кнопку Add New" открывает форму (модальное окно) для заполнения нового сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }


       
        /// <summary>
        /// Удаление выбранной строки из таблицы и списка сотрудников. Пересчет всех Id в списке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (spisokEmployees.Count != 0)
            {
                try
                {
                    int delet = dataGridViewListEmployee.SelectedCells[0].RowIndex;
                    dataGridViewListEmployee.Rows.RemoveAt(delet);
                    int i = 0;
                    foreach (var item in spisokEmployees)
                    {
                        item.Id = i;
                        i++;
                    }
                    Employee.DoSerial(spisokEmployees);
                }
                catch
                {
                    MessageBox.Show("Выберите строку!");
                }
            }
            else
            {
                MessageBox.Show("Список пуст!");
            }
        }

        /// <summary>
        /// Событие "Нажатие на кнопку "Search" открывает форму поиска (модальное окно).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}
