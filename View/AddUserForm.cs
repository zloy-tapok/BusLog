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
    public partial class AddUserForm : Form
    {
        /// <summary>
        /// Пустой список и переменная для работы в разных событиях.
        /// </summary>
        List<Employee> spisokEmployees = new List<Employee>();
        int i = 0;

        public AddUserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При загрузке формы происходит десериализация списка (если файл не пустой).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            spisokEmployees = Employee.DoDeserial();

            if (spisokEmployees.Count != 0)
            {
                foreach (var item in spisokEmployees)
                {
                    i = item.Id;
                    i++;
                }
            }
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

        private void maskedTextBoxWork1_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxWork1.SelectionStart = 0;
        }

        private void maskedTextBoxWork2_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxWork2.SelectionStart = 0;
        }

        private void maskedTextBoxWork3_MouseClick(object sender, MouseEventArgs e)
        {
            maskedTextBoxWork3.SelectionStart = 0;
        }

        #endregion

        #region RadioButton (все) и их поведение.
        private void radioButtonWorkers_CheckedChanged(object sender, EventArgs e)
        {
            labelWork1.Text = "Price Hour";
            labelWork2.Text = "Number of Hours";
            labelWork3.Visible = false;
            maskedTextBoxWork3.Visible = false;
        }
       
        private void radioButtonSpecialists_CheckedChanged(object sender, EventArgs e)
        {
            labelWork1.Text = "Oklad";
            labelWork2.Text = "Norma of days";
            labelWork3.Text = "Fact days";
            labelWork3.Visible = true;
            maskedTextBoxWork3.Visible = true;

        }

        private void radioButtonManagers_CheckedChanged(object sender, EventArgs e)
        {
            labelWork1.Text = "Stavka day";
            labelWork2.Text = "Fact days";
            labelWork3.Visible = false;
            maskedTextBoxWork3.Visible = false;
        }
        #endregion

        /// <summary>
        /// Событие "Нажатие на кнопку Ok" присваивает данные объекту списка и записывает в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            #region Условие If - проверка на пустое поле.
            if (string.IsNullOrWhiteSpace(maskedTextBoxFname.Text))
            {
                MessageBox.Show("Вы не заполнили Имя.");             
            }
            else if (string.IsNullOrWhiteSpace(maskedTextBoxSname.Text))
                {
                MessageBox.Show("Вы не заполнили Фамилию.");
                }
            else if (string.IsNullOrWhiteSpace(maskedTextBoxLname.Text))
            {
                MessageBox.Show("Вы не заполнили Отчество.");
            }
            else if (string.IsNullOrWhiteSpace(maskedTextBoxAge.Text))
            {
                MessageBox.Show("Вы не заполнили Возраст.");
            }
            else if (int.Parse(maskedTextBoxAge.Text) < 18)
            {
                MessageBox.Show("Нельзя брать на работу людей младше 18 лет.");
            }
            else if (int.Parse(maskedTextBoxAge.Text) > 120)
            {
                MessageBox.Show("Слишком большой возраст.");
            }
            else if (string.IsNullOrWhiteSpace(maskedTextBoxPhone.Text))
            {
                MessageBox.Show("Вы не заполнили Телефон.");
            }
            else if (string.IsNullOrWhiteSpace(maskedTextBoxProfession.Text))
            {
                MessageBox.Show("Вы не заполнили Профессию.");
            }
            else if (string.IsNullOrWhiteSpace(maskedTextBoxWork1.Text) || string.IsNullOrWhiteSpace(maskedTextBoxWork2.Text))
            {
                MessageBox.Show("Вы не заполнили все поля для расчета зарплаты.");
            }
            else if(radioButtonSpecialists.Checked && string.IsNullOrWhiteSpace(maskedTextBoxWork3.Text))           
            {
                    MessageBox.Show("Вы не заполнили все поля для расчета зарплаты.");
            }
            #endregion
            #region Присвоение значений и расчет зарплаты.
            else
            {
                spisokEmployees.Add(new Employee());
                spisokEmployees[i].Id = i;
                spisokEmployees[i].Fname = maskedTextBoxFname.Text;
                spisokEmployees[i].Sname = maskedTextBoxSname.Text;
                spisokEmployees[i].Lname = maskedTextBoxLname.Text;
                spisokEmployees[i].Age = int.Parse(maskedTextBoxAge.Text);
                spisokEmployees[i].Phone = int.Parse(maskedTextBoxPhone.Text);
                spisokEmployees[i].Profession = maskedTextBoxProfession.Text;

                /// <summary>
                /// Категория "Workers". Закомментировал строку рассчета через метод интерфейса.
                /// Так код будет короче, но менее понятный.
                /// </summary>
                if (radioButtonWorkers.Checked)
                {
                    var worker = new Worker1();
                    worker.HourPrice = int.Parse(maskedTextBoxWork1.Text);
                    worker.HourNumber = int.Parse(maskedTextBoxWork2.Text);
                    spisokEmployees[i].Zarplata = worker.HourPrice * worker.HourNumber;
                    //spisokEmployees[i].RashetZarplata(int.Parse(maskedTextBoxWork1.Text), int.Parse(maskedTextBoxWork2.Text));
                }
                /// <summary>
                /// Категория "Specialists". Закомментировал строку рассчета через метод интерфейса.
                /// Так код будет короче, но менее понятный.
                /// </summary>
                else if (radioButtonSpecialists.Checked)
                {
                    var worker = new Worker2();
                    worker.Oklad = int.Parse(maskedTextBoxWork1.Text);
                    worker.DaysNorm = int.Parse(maskedTextBoxWork2.Text);
                    worker.DaysNorm = int.Parse(maskedTextBoxWork3.Text);
                    spisokEmployees[i].Zarplata = worker.Oklad / worker.DaysNorm * worker.DaysFact;
                    //spisokEmployees[i].RashetZarplata(int.Parse(maskedTextBoxWork1.Text), int.Parse(maskedTextBoxWork2.Text), int.Parse(maskedTextBoxWork3.Text));
                }
                /// <summary>
                /// Категория "Managers". Закомментировал строку рассчета через метод интерфейса.
                /// Так код будет короче, но менее понятный.
                /// </summary>
                else if (radioButtonManagers.Checked)
                {
                    var worker = new Worker3();
                    worker.DayStavka = int.Parse(maskedTextBoxWork1.Text);
                    worker.DayFact = int.Parse(maskedTextBoxWork2.Text);
                    spisokEmployees[i].Zarplata = worker.DayStavka * worker.DayFact;
                    //spisokEmployees[i].RashetZarplata(int.Parse(maskedTextBoxWork1.Text), int.Parse(maskedTextBoxWork2.Text));
                }

                Employee.DoSerial(spisokEmployees);

                this.Close();
                
            }
            #endregion
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

#if DEBUG
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            buttonRandom.Visible = true;

            maskedTextBoxFname.Text = Guid.NewGuid().ToString().Substring(0, 5);
            maskedTextBoxSname.Text = Guid.NewGuid().ToString().Substring(0, 5);
            maskedTextBoxLname.Text = Guid.NewGuid().ToString().Substring(0, 5);
            maskedTextBoxProfession.Text = Guid.NewGuid().ToString().Substring(0, 5);
            
            Random rnd = new Random();
            maskedTextBoxAge.Text = (rnd.Next(1, 100)).ToString();
            maskedTextBoxPhone.Text = (rnd.Next(1, 100)).ToString();
            maskedTextBoxWork1.Text = (rnd.Next(1, 100)).ToString();
            maskedTextBoxWork2.Text = (rnd.Next(1, 100)).ToString();
            maskedTextBoxWork3.Text = (rnd.Next(1, 100)).ToString();

        }
#endif

    }
}
