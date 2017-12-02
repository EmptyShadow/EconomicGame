using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Economic.Buildings
{
    [Serializable]
    /// <summary>
    /// Магазин
    /// </summary>
    public class Market : Building, ICloneable
    {
        /// <summary>
        /// Максимальный объем прибыли магазина в месяц
        /// </summary>
        uint maxProfit;

        /// <summary>
        /// Процент увеличения стоимости здания после постройки
        /// </summary>
        double procentCostInc;

        public Market() { }

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
            this.procentCostInc = procentCostInc / 100.0;
        }

        /// <summary>
        /// Получение или установление максимального объема прибыли за месяц
        /// </summary>
        public uint MaxProfit
        {
            get
            {
                return maxProfit;
            }
            set
            {
                if (maxProfit == 0 && value != 0)
                {
                    maxProfit = value;
                }
            }
        }

        /// <summary>
        /// Получение или установление процента увеличения стоимости магазина после постройки
        /// </summary>
        public double ProcentCostInc
        {
            get
            {
                return procentCostInc;
            }
            set
            {
                if (procentCostInc == 0.0 && value != 0.0)
                {
                    procentCostInc = value;
                }
            }
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

        /// <summary>
        /// Сделать копию объекта
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            Market clone = new Market(name, buildingPeriod, cost, maxProfit, procentCostInc);
            clone.costMonth = CostMonth;
            clone.curBuildingPeriod = curBuildingPeriod;
            clone.freeze = freeze;
            return clone;
        }

        /// Краткая информация
        /// </summary>
        /// <returns></returns>
        public override string ShortInfo()
        {
            string s = base.ShortInfo();

            s += "Максимальный объем прибыли магазина в месяц " + maxProfit.ToString() + "\n";
            s += "Процент увеличения стоимости здания после постройки " + procentCostInc.ToString() + "\n";

            return s;
        }
    }
}
