using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src
{
    /// <summary>
    /// Сезон времени года
    /// </summary>
    class Season
    {
        /// <summary>
        /// Получить месяц по номеру месяца
        /// </summary>
        /// <param name="numMonth">Номер месяца есть больше 12, то будет взято 
        /// по модулю 12</param>
        /// <returns></returns>
        public static Seasons GetSeasonByNumMonth(int numMonth)
        {
            numMonth %= 12;
            if (0 <= numMonth && numMonth <= 2)
            {
                return Seasons.Winter;
            } else if (3 <= numMonth && numMonth <= 5)
            {
                return Seasons.Spring;
            } if (6 <= numMonth && numMonth <= 8)
            {
                return Seasons.Summer;
            } else
            {
                return Seasons.Autumn;
            }
        }

        /// <summary>
        /// Получить время года по его номеру
        /// </summary>
        /// <param name="num">Номер времени года от 1 до 4</param>
        /// <returns></returns>
        public static Seasons GetSeasonByNum(int num)
        {
            if (1 <= num && num <= 4)
            {
                return (Seasons)num;
            }
            throw new Exception("Нет такого месяца");
        }
    }
    
    /// <summary>
    /// Времена года
    /// </summary>
    enum Seasons { Winter = 1, Summer, Spring, Autumn };
}
