using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс "Категория работника №2" - "Специалисты".
    /// Всего три таких класса, которые отличаются рассчетом зарплаты и входными параметрами.
    /// Зарплата = Оклад разделить на норму дней и умножить на количество фактических дней.
    /// </summary>
    [Serializable]
    public class Worker2 : Human
    {
        /// <summary>
        /// Размер Оклада.
        /// </summary>
        public int Oklad { get; set; }

        /// <summary>
        /// Количество положенных (норма) дней.
        /// </summary>
        public int DaysNorm { get; set; }

        /// <summary>
        /// Количество фактически отработаннх дней.
        /// </summary>
        public int DaysFact { get; set; }

    }
}
