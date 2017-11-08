using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Economic.Buildings
{
    /// <summary>
    /// Здание, сооружение
    /// </summary>
    class Building
    {
        /// <summary>
        /// Название здания
        /// </summary>
        string name;

        /// <summary>
        /// Общий период строительства
        /// </summary>
        uint buildingPeriod;

        /// <summary>
        /// Общая стоимость
        /// </summary>
        uint cost;

        /// <summary>
        /// Прошедшее время с начала строительства
        /// </summary>
        uint curBuildingPeriod;

        /// <summary>
        /// Плата за месяц
        /// </summary>
        uint costMonth;

        /// <summary>
        /// Заморозка строительства. В этот период здание не строится и на него не
        /// расходуются денежные средства
        /// </summary>
        bool freeze = false;

        public Building(string name, uint buildingPeriod, uint cost)
        {
            this.name = name;
            this.buildingPeriod = buildingPeriod;
            this.cost = cost;
            costMonth = buildingPeriod / cost;
        }

        /// <summary>
        /// Статус заморозки строительства здания
        /// </summary>
        public bool IsFreeze
        {
            get
            {
                // Если здание построенно
                if (IsBuild())
                {
                    // ,то его невозможно заморозить
                    return true;
                }
                // иначе вернуть статус заморозки
                return freeze;
            }
            set
            {
                // Если здание не построенно
                if (!IsBuild())
                {
                    // То меняем статус заморозки
                    freeze = value;
                }
            }
        }

        /// <summary>
        /// Здание построенно?
        /// </summary>
        /// <returns></returns>
        public bool IsBuild()
        {
            // Если прошедшее время совподает с плановым временем строительства, то здание построенно
            return curBuildingPeriod == buildingPeriod;
        }

        /// <summary>
        /// Задержка строительства
        /// </summary>
        public void DelayBuilding()
        {
            // Если задержали строительство, то плановый период строительства увеличивается на один месяц
            buildingPeriod++;
        }
    }
}
