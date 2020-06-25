using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для составления общих правил введения переменных
    /// </summary>
    public static class SetRules
    {
        /// <summary>
        /// Метод контроля устанавливаемых значений цены и скидки
        /// </summary>
        /// <param name="text">Название параметра</param>
        /// <param name="value">Устанавливаемая велечина</param>
        /// <returns>Корректное значение цены или скидки</returns>
        public static double SetValue(string text, double value)
        {
            if ((value <= 0) || (Double.IsNaN(value)))
            {
                throw new ArgumentOutOfRangeException($"{text} должна " +
                    "быть больше 0.");
            }

            return Math.Round(value, 2);
        }
    }
}
