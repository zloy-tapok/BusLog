using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{   
    /// <summary>
    /// Базовый класс "Человек".
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
        public string Fname { get; set; }

        /// <summary>
        /// Фамилия объекта.
        /// </summary>
        public string Sname { get; set; }

        /// <summary>
        /// Отчетсво объекта.
        /// </summary>
        public string Lname { get; set; }

        /// <summary>
        /// Возраст объекта.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Номер телефона объекта.
        /// </summary>
        public int Phone { get; set; }

        /// <summary>
        /// Профессия объекта.
        /// </summary>
        public string Profession { get; set; }
    }
}
