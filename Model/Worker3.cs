using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс "Категория работника №3" - "Менеджеры".
    /// Всего три таких класса, которые отличаются рассчетом зарплаты и входными параметрами.
    /// Зарплата = Ставка умножить на количество отработанных дней.
    /// </summary>
    [Serializable]
    public class Worker3 : Human
    {
        /// <summary>
        /// Размер дневной ставки.
        /// </summary>
        public int DayStavka { get; set; }

        /// <summary>
        /// Количество отработанных дней.
        /// </summary>
        public int DayFact { get; set; }

    }
}
