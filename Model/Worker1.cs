using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс "Категория работника №1" - "Рабочие".
    /// Всего три таких класса, которые отличаются рассчетом зарплаты и входными параметрами.
    /// Зарплата = Стоимость одного рабочего часа умножить на Количество отработанных часов.
    /// </summary>
    [Serializable]
    public class Worker1 : Human
    {
        /// <summary>
        /// Стоимость одного рабочего часа.
        /// </summary>
        public int HourPrice { get; set; }

        /// <summary>
        /// Количество отработаннх часов в месяц.
        /// </summary>
        public int HourNumber { get; set; }
    }
}
