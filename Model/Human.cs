using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{   
    /// <summary>
    /// Базовый класс "Человек".
    /// Сериализуемый.
    /// </summary>
    [Serializable]
    public class Human
    {  
        /// <summary>
        /// Номер объекта.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя объекта.
        /// </summary>
        public string First_name { get; set; }

        /// <summary>
        /// Фамилия объекта.
        /// </summary>
        public string Second_name { get; set; }

        /// <summary>
        /// Отчетсво объекта.
        /// </summary>
        public string Last_name { get; set; }

        /// <summary>
        /// Возраст объекта.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Номер телефона объекта.
        /// </summary>
        public long Phone { get; set; }

        /// <summary>
        /// Профессия объекта.
        /// </summary>
        public string Profession { get; set; }
    }
}
