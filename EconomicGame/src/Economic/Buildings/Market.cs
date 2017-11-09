using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Economic.Buildings
{
    /// <summary>
    /// Магазин
    /// </summary>
    class Market : Building
    {
        /// <summary>
        /// Максимальный объем прибыли магазина
        /// </summary>
        uint maxProfit;

        /// <summary>
        /// Процент увеличения стоимости здания после постройки
        /// </summary>
        double procentCostInc;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="buildingPeriod">Период строительства</param>
        /// <param name="cost">Стоимость</param>
        /// <param name="maxProfit">Максимальная прибыль</param>
        /// <param name="procentCostInc">Процент увеличения стоимости здания</param>
        public Market(string name, uint buildingPeriod, uint cost, uint maxProfit, double procentCostInc = 60) : base(name, buildingPeriod, cost)
        {
            this.maxProfit = maxProfit;
        }

        /// <summary>
        /// Получить стоимость здания
        /// </summary>
        /// <returns></returns>
        public override uint GetCurCost()
        {
            // Если здание построенно
            if (IsBuild())
            {
                // , то его стоимость на % больше чем его стоимость строительства
                return (uint)((double)cost + procentCostInc / 100.0 * (double)cost);
            }
            //, иначе стоимость не построенного
            return base.GetCurCost();
        }


    }
}
