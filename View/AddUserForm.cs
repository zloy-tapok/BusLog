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
    /// Форма добавления нового сотрудника в список.
    /// Здесь проводятся всевозможные проверки корректности данных.
    /// И расчет зарплаты (и ее округление).
    /// </summary>
    public partial class AddUserForm : Form
    {
      
        static List<TextBoxses> spisokMyTextBox = new List<TextBoxses>();
        
        /// <summary>
        /// Метод выполняет проверку MaskedTextBox-ов.
        /// С помощью цикла пробегает по всему списку форм, добавленных при инциализации.
        /// </summary>
        /// <returns></returns>
        public static bool Check()
        {
            foreach (var i in spisokMyTextBox)
            {
                if (i.Check(i.MyControl))
                {
                    MessageBox.Show(i.Message);
                    return false;
                }
                                  
            }
            return true;
        }
        
        /// <summary>
        /// Заполнение списка для проверки Текст Боксов при инициализации формы.
        /// </summary>
        public AddUserForm()
        {
            InitializeComponent();
            
            spisokMyTextBox.Add(new TextBoxses("Error: First Name field is empty.", maskedTextBoxFname));
            spisokMyTextBox.Add(new TextBoxses("Error: Second Name field is empty.", maskedTextBoxSname));
            spisokMyTextBox.Add(new TextBoxses("Error: Last Name field is empty.", maskedTextBoxLname));
            spisokMyTextBox.Add(new TextBoxses("Error: Age field is empty.", maskedTextBoxAge));
            spisokMyTextBox.Add(new TextBoxses("Error: Phone field is empty.", maskedTextBoxPhone));
            spisokMyTextBox.Add(new TextBoxses("Error: Profession field is empty.", maskedTextBoxProfession));
            spisokMyTextBox.Add(new TextBoxses("Error: You did not fill out all the fields for payroll.", maskedTextBoxWork2));
            spisokMyTextBox.Add(new TextBoxses("Error: You did not fill out all the fields for payroll.", maskedTextBoxWork3, (x) => radioButtonSpecialists.Checked && string.IsNullOrWhiteSpace(x.Text)));
            spisokMyTextBox.Add(new TextBoxses("Error: Age < 18", maskedTextBoxAge, (x) => int.Parse(x.Text) < 18));
            spisokMyTextBox.Add(new TextBoxses("Error: Age > 120 (Too old).", maskedTextBoxAge, (x) => int.Parse(x.Text) > 120));
            spisokMyTextBox.Add(new TextBoxses("Error: Number hour > 744 (hours in month).", maskedTextBoxWork2, (x) => radioButtonWorkers.Checked && int.Parse(x.Text) > 744));
            spisokMyTextBox.Add(new TextBoxses("Error: Norma of days < 1.", maskedTextBoxWork2, (x) => radioButtonSpecialists.Checked && int.Parse(x.Text) < 1));
            spisokMyTextBox.Add(new TextBoxses("Error: Norma of days > 31.", maskedTextBoxWork2, (x) => radioButtonSpecialists.Checked && int.Parse(x.Text) > 31));
            spisokMyTextBox.Add(new TextBoxses("Error: Fact days > 31.", maskedTextBoxWork3, (x) => radioButtonSpecialists.Checked && int.Parse(x.Text) > 31));
            spisokMyTextBox.Add(new TextBoxses("Error: Fact days > 31.", maskedTextBoxWork2, (x) => radioButtonManagers.Checked && int.Parse(x.Text) > 31));
        }


        /// <summary>
        /// Все maskedTextBox - установка курсора на начало.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            MaskedTextBox control = sender as MaskedTextBox;
            control.SelectionStart = 0;
        }

      
        /// <summary>
        /// Переключатели radioButton и их поведение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButtonWorkers)
            {
                labelWork1.Text = "Price Hour";
                labelWork2.Text = "Number of Hours";
                labelWork3.Visible = false;
                maskedTextBoxWork3.Visible = false;
            }
            else if (sender == radioButtonSpecialists)
            {
                labelWork1.Text = "Oklad";
                labelWork2.Text = "Norma of days";
                labelWork3.Text = "Fact days";
                labelWork3.Visible = true;
                maskedTextBoxWork3.Visible = true;
            }
            else if(sender == radioButtonManagers)
             {
                labelWork1.Text = "Stavka day";
                labelWork2.Text = "Fact days";
                labelWork3.Visible = false;
                maskedTextBoxWork3.Visible = false;
            }
        }



        /// <summary>
        /// Метод запускается по нажатию кнопки OK. 
        /// В случае удачной проверки форм, присваивает значение и считает зарплату.
        /// Передает данные в основную форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(Check())
           
            #region Присвоение значений и расчет зарплаты.
 
            {
                var newEmployee = new Employee();
                newEmployee.First_name = maskedTextBoxFname.Text;
                newEmployee.Second_name = maskedTextBoxSname.Text;
                newEmployee.Last_name = maskedTextBoxLname.Text;
                newEmployee.Age = int.Parse(maskedTextBoxAge.Text);
                newEmployee.Phone = long.Parse(maskedTextBoxPhone.Text);
                newEmployee.Profession = maskedTextBoxProfession.Text;

             
                if (radioButtonWorkers.Checked)
                {
                  
                    newEmployee.Zarplata = Math.Round(decimal.Parse(numericUpDownWork1.Text) 
                                                      * int.Parse(maskedTextBoxWork2.Text), 2);
                    
                   
                }
           
                else if (radioButtonSpecialists.Checked)
                {
                   
                    newEmployee.Zarplata = Math.Round(decimal.Parse(numericUpDownWork1.Text) 
                                                        / int.Parse(maskedTextBoxWork2.Text) 
                                                        * int.Parse(maskedTextBoxWork3.Text), 2);
                    
                }
        
                else if (radioButtonManagers.Checked)
                {
                  
                    newEmployee.Zarplata = Math.Round(decimal.Parse(numericUpDownWork1.Text) 
                                                       * int.Parse(maskedTextBoxWork2.Text), 2);
                   
                }
                #endregion

                MainForm mainForm = (MainForm)Owner;
                mainForm.spisokEmployees.Add(newEmployee);
                this.Close();                
            }
        }

        /// <summary>
        /// Метод запускаемый по нажатию кнопки Cancel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Метод запускаемый по нажатию кнопки Generate Random Data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {

            maskedTextBoxFname.Text = Path.GetRandomFileName().Replace(".", "").Substring(0, 8);
            maskedTextBoxSname.Text = Path.GetRandomFileName().Replace(".", "").Substring(0, 8);
            maskedTextBoxLname.Text = Path.GetRandomFileName().Replace(".", "").Substring(0, 8);
            maskedTextBoxProfession.Text = Path.GetRandomFileName().Replace(".", "").Substring(0, 8);

            Random rnd = new Random();

            maskedTextBoxAge.Text = (rnd.Next(1, 100)).ToString();
            maskedTextBoxPhone.Text = (rnd.Next(1, 100)).ToString();
            numericUpDownWork1.Text = (rnd.Next(1, 100)).ToString();
            maskedTextBoxWork2.Text = (rnd.Next(1, 100)).ToString();
            maskedTextBoxWork3.Text = (rnd.Next(1, 100)).ToString();
        }

        
    }
}
