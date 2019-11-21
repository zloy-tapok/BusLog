
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{   /// <summary>
    /// Из объектов данного класса создается список всех наших текстовых форм.
    /// Тип форм - MaskedTextBox.
   /// </summary>
    public class TextBoxses
    {
        /// <summary>
        /// Сообщение выводимое пользователю при ошибки заполнения формы.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Свойство проверки форм.
        /// </summary>
        public Func<System.Windows.Forms.MaskedTextBox, bool> Check { get; set; }
        /// <summary>
        /// Свойство для "связывания" объекта с классом форм.
        /// </summary>
        public System.Windows.Forms.MaskedTextBox MyControl { get; set; }
        /// <summary>
        /// Конструктор для объектов с проверкой на пустоту.
        /// Сокращает количество кода при добавлении объктов в список.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mycontrol"></param>
        public TextBoxses(string message, System.Windows.Forms.MaskedTextBox mycontrol)
        { 
            Message = message; 
            MyControl = mycontrol; 
            Check = (x) => string.IsNullOrWhiteSpace(x.Text); 
        }
        /// <summary>
        /// Добавляется параметр для выбора проверки.
        /// Указываем любое условие (в рамках допустимого) для проверки значений в MaskedTextBox-ах.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="mycontrol"></param>
        /// <param name="chek"></param>
        public TextBoxses(string message, System.Windows.Forms.MaskedTextBox mycontrol, Func<System.Windows.Forms.MaskedTextBox, bool> chek)
        {
            Message = message;
            MyControl = mycontrol;
            Check = chek;
        }


    }
}
