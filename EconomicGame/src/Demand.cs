using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src
{
    /// <summary>
    /// Спрос на вещь/товар
    /// </summary>
    class Demand
    {
        /// <summary>
        /// Стоимость вещи
        /// </summary>
        uint costThing;
        /// <summary>
        /// Количество вещей, которое купят за эту цену
        /// </summary>
        uint countThings;

        /// <summary>
        /// Создать объект спроса
        /// </summary>
        /// <param name="costThing">цена объекта</param>
        /// <param name="countThings">количество объектов, которые купят за эту стоимость</param>
        public Demand(uint costThing, uint countThings)
        {
            this.costThing = costThing;
            this.countThings = countThings;
        }

        /// <summary>
        /// Получить новую стоимость вещи, по количеству товаров, которые нужно продать
        /// </summary>
        /// <param name="nextCount"></param>
        /// <returns></returns>
        public uint GetNextCost(uint nextCount)
        {
            // Стоимость * требуемое количество / текущее количество
            return (uint)(costThing * nextCount / countThings);
        }

        /// <summary>
        /// Получить количество проданных вещей по новой цене
        /// </summary>
        /// <param name="nextCost"></param>
        /// <returns></returns>
        public uint GetNextCount(uint nextCost)
        {
            // текущее количество * новую стоимость / текущая стоимость
            return (uint)(countThings * nextCost / costThing);
        }
    }
}
