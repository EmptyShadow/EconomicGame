using System;

namespace EconomicGame.src.Economic.Buildings
{
    [Serializable]
    /// <summary>
    /// Здание, сооружение
    /// </summary>
    public class Building : ICloneable
    {
        /// <summary>
        /// Название здания
        /// </summary>
        protected string name;

        /// <summary>
        /// Общий период строительства
        /// </summary>
        protected uint buildingPeriod;

        /// <summary>
        /// Общая стоимость
        /// </summary>
        protected uint cost;

        /// <summary>
        /// Плата за месяц строительства
        /// </summary>
        protected uint costMonth;

        /// <summary>
        /// Прошедшее время с начала строительства
        /// </summary>
        protected uint curBuildingPeriod;

        /// <summary>
        /// Процент полученный за счет рекламы. Действует только месяц
        /// </summary>
        protected double percentageAdvertising = 0.0;

        /// <summary>
        /// Заморозка строительства. В этот период здание не строится и на него не
        /// расходуются денежные средства
        /// </summary>
        protected bool freeze = false;

        /// <summary>
        /// Количество выгодных соседей
        /// </summary>
        public uint CountNeighbors { get; set; } = 0;

        public Building() {}

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название здания</param>
        /// <param name="buildingPeriod">Период строительства</param>
        /// <param name="cost">Стоимость</param>
        public Building(string name, uint buildingPeriod, uint cost)
        {
            this.name = name;
            this.buildingPeriod = buildingPeriod;
            this.cost = cost;
            //  стоимостьпериод / строительства
            costMonth = cost / buildingPeriod;
        }

        /// <summary>
        /// Название здания
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name == null && value != null)
                {
                    name = value;
                }
            }
        }

        /// <summary>
        /// Общий период строительства
        /// </summary>
        public uint BuldingPeriod
        {
            get
            {
                return buildingPeriod;
            }
            set
            {
                if (buildingPeriod == 0 && value != 0)
                {
                    buildingPeriod = value;
                    if (cost != 0)
                    {
                        costMonth = cost / buildingPeriod;
                    }
                }
            }
        }

        /// <summary>
        /// Общая стоимость строительства
        /// </summary>
        public uint Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (cost == 0 && value != 0)
                {
                    cost = value;
                    if (buildingPeriod != 0)
                    {
                        costMonth = cost / buildingPeriod;
                    }
                }
            }
        }

        /// <summary>
        /// Плата за месяц строительства
        /// </summary>
        public uint CostMonth
        {
            get
            {
                return costMonth;
            }
        }

        /// <summary>
        /// Статус заморозки строительства здания,
        /// True - замороженно строитьльство
        /// False - не замороженно
        /// </summary>
        public bool IsFreeze
        {
            get
            {
                // Если здание построенно
                if (IsBuild())
                {
                    // ,то его невозможно заморозить
                    return false;
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
        /// Процент полученный за счет рекламы. Действует только месяц
        /// </summary>
        public double PercentageAdvertising
        {
            get
            {
                return percentageAdvertising;
            }
            set
            {
                percentageAdvertising = value;
            }
        }

        /// <summary>
        /// Здание построенно?
        /// </summary>
        /// <returns></returns>
        public bool IsBuild()
        {
            // Если прошедшее время совподает с плановым временем строительства, то здание построенно
            return curBuildingPeriod == buildingPeriod && !(freeze = false);
        }

        /// <summary>
        /// Задержка строительства
        /// </summary>
        public void DelayBuilding()
        {
            // Если задержали строительство, то плановый период строительства увеличивается на один месяц
            buildingPeriod++;
        }

        public void NextStageBuilding()
        {
            // Увеличить процесс постройки
            curBuildingPeriod++;
        }

        /// <summary>
        /// Остаточный период строительства
        /// </summary>
        /// <returns></returns>
        public uint ResidualPeriodBuilding()
        {
            return buildingPeriod - curBuildingPeriod;
        }

        /// <summary>
        /// Получить стоимость здания
        /// </summary>
        /// <returns></returns>
        public virtual uint GetCurCost()
        {
            // оплата за месяц * период строительства
            return costMonth * curBuildingPeriod;
        }

        /// <summary>
        /// Сделать копию объекта
        /// </summary>
        /// <returns></returns>
        public virtual Object Clone()
        {
            Building clone = new Building(name, buildingPeriod, cost);
            clone.costMonth = CostMonth;
            clone.curBuildingPeriod = curBuildingPeriod;
            clone.freeze = freeze;
            return clone;
        }
    }
}
