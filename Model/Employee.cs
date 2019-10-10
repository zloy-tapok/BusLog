using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Производный класс "Сотрудник" - наследуется от класса "Человек". 
    /// </summary>
    [Serializable]
    public class Employee : Human, ISerial
    {
        /// <summary>
        /// Автосвойство Зарплата объекта.
        /// </summary>
        public int Zarplata { get; set; }

        /// <summary>
        /// Метод Сериализации списка.
        /// </summary>
        /// <param name="spisokEmployees"></param>
        public static void DoSerial(List<Employee> spisokEmployees)
        {
            var formatter = new BinaryFormatter();
            using (var filestream = new FileStream("employee.data", FileMode.OpenOrCreate))
            {
                formatter.Serialize(filestream, spisokEmployees);
            }
           
        }

        /// <summary>
        /// Метод Десериализации списка.
        /// </summary>
        /// <param name="spisokEmployees"></param>
        public static List<Employee> DoDeserial()
        {
            List<Employee> spisokEmployees = new List<Employee>();
            var formatter = new BinaryFormatter();
            using (var filestream = new FileStream("employee.data", FileMode.OpenOrCreate))
            {
                if (filestream.Length != 0)
                {
                    return spisokEmployees = formatter.Deserialize(filestream) as List<Employee>;
                }
                else
                {

                    return spisokEmployees;
                }
                
            }
        }
        /// <summary>
        /// Неиспользуемые методы. 
        /// Для тех задания - наличие интерфейса.
        /// </summary>
        /// <param name="work1"></param>
        /// <param name="work2"></param>
        public void RashetZarplata(int work1, int work2)
        {
            Zarplata = work1 * work2;
        }

        /// <summary>
        /// Неиспользуемые методы. 
        /// Для тех задания - наличие интерфейса.
        /// </summary>
        public void RashetZarplata(int work1, int work2, int work3)
        {
            Zarplata = work1 / work2 * work3;
        }
    }
}
