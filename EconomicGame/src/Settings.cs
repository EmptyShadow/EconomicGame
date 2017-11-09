using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src
{
    /// <summary>
    /// Настройки игрового процесса
    /// </summary>
    class Settings
    {
        // спрос
        // добавить
        // уровень продаж
        // добавить

        /// <summary>
        /// Коэффициенты сезонов
        /// </summary>
        double[] coefSeasons;

        /// <summary>
        /// граница благоприятного события
        /// </summary>
        double borderFavorableOutcome;

        public Settings()
        {
        }

        /// <summary>
        /// Получение коэффициента благоприятного события
        /// </summary>
        public double BorderFavorableOutcome
        {
            get
            {
                return borderFavorableOutcome;
            }
        }
    }
}
