using System;

namespace EconomicGame.src.Economic
{
    [Serializable]
    /// <summary>
    /// Спрос на вещь/товар
    /// </summary>
    public class Demand
    {
        /// <summary>
        /// Стоимость вещи
        /// </summary>
        uint costThing;
        /// <summary>
        /// Количество вещей, которое купят за эту цену
        /// </summary>
        uint countThings;

        public Demand() { }

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
        /// Получение или установление цена на вещь
        /// </summary>
        public uint CostThings
        {
            get
            {
                return costThing;
            }
            set
            {
                if (costThing == 0 && value != 0)
                {
                    costThing = value;
                }
            }
        }

        /// <summary>
        /// Отношение цены к количеству
        /// </summary>
        /// <returns></returns>
        public double RatioCostCount()
        {
            return costThing / countThings;
        }

        /// <summary>
        /// Получение или установка количество вещей, которое будет куплено
        /// </summary>
        public uint CountThings
        {
            get
            {
                return countThings;
            }
            set
            {
                if (countThings == 0 && value != 0)
                {
                    countThings = value;
                }
            }
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
