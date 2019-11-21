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
    /// Сериализуемый.
    /// </summary>
    [Serializable]
    public class Employee : Human
    {
        /// <summary>
        /// Автосвойство Зарплата объекта.
        /// </summary>
        public decimal Zarplata { get; set; }
    }
      
}
