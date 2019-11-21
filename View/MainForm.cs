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
    /// Проводятся операции  открытия и сохранения файла.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Новый пустой список сотрудников для дальнейших манипуляций.
        /// </summary>
        public List<Employee> spisokEmployees = new List<Employee>();
       
        /// <summary>
        /// Метод обновления таблицы из списка (циклом).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DataGridViewListEmployee_Refresh()
        {
            dataGridViewListEmployee.Rows.Clear();
            int i = 0;
            foreach (var item in spisokEmployees)
            {
                item.Id = i;
                dataGridViewListEmployee.Rows.Add(spisokEmployees[i].Id, spisokEmployees[i].First_name, spisokEmployees[i].Second_name, 
                                                  spisokEmployees[i].Last_name, spisokEmployees[i].Age, spisokEmployees[i].Phone, 
                                                  spisokEmployees[i].Profession, spisokEmployees[i].Zarplata);
                i++;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При каждой активации основной формы, обновляется таблица из списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Activated(object sender, EventArgs e)
        {
            DataGridViewListEmployee_Refresh();
        }

        /// <summary>
        /// Событие "Нажатие на кнопку Add New" открывает форму (модальное окно) для заполнения нового сотрудника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm();
            addUserForm.ShowDialog(this);
            
        }



        /// <summary>
        /// Удаление выбранной строки из таблицы и списка сотрудников.
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
                    spisokEmployees.RemoveAt(delet);
                }
                catch
                {
                    MessageBox.Show("Select row!");
                }
            }
            else
            {
                MessageBox.Show("List empty!");
            }
            DataGridViewListEmployee_Refresh();
        }

        /// <summary>
        /// Событие "Нажатие на кнопку "Search" открывает форму поиска (модальное окно).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            searchForm.ShowDialog(this);
        }

    
        /// <summary>
        /// Открытие файла из главного меню.
        /// Бинарная десиреализация.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openMainFormDialog = new OpenFileDialog();
            openMainFormDialog.FileName = "filename";
            openMainFormDialog.Filter = "Data (*.data)|*.data|Text (*.txt)|*.txt|All files (*.*)|*.*";

            var formatter = new BinaryFormatter();       
            if (openMainFormDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream str = openMainFormDialog.OpenFile())
                    {
                        if (str.Length != 0)
                        {
                            spisokEmployees = formatter.Deserialize(str) as List<Employee>;
                        }
                        else
                        {
                            MessageBox.Show("Error: empty file.");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error open file.");
                }
            }
            DataGridViewListEmployee_Refresh();
        }
        /// <summary>
        /// Сохранение в файл в главном меню.
        /// Бинарная сериализация.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveMainFormDialog = new SaveFileDialog();
            saveMainFormDialog.FileName = "filename";
            saveMainFormDialog.Filter = "Data (*.data)|*.data|Text (*.txt)|*.txt|All files (*.*)|*.*";

            var formatter = new BinaryFormatter();
            if (saveMainFormDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Stream str = saveMainFormDialog.OpenFile())
                    {
                       formatter.Serialize(str,spisokEmployees);
                    }
                }
                catch
                {
                    MessageBox.Show("Error save file.");
                }
            }
        }

        /// <summary>
        /// Закрытие формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
