using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Economic.Buildings
{
    [Serializable]
    /// <summary>
    /// Жилой дом
    /// </summary>
    public class House : Building, ICloneable
    {
        /// <summary>
        /// Количество квартир
        /// </summary>
        uint countСondo;

        /// <summary>
        /// Количество проданных квартир
        /// </summary>
        uint countSoldCondo;

        /// <summary>
        /// Среднее количество м^2 в квартире
        /// </summary>
        uint averageSquareMetersCondos;

        /// <summary>
        /// Стоимость м^2
        /// </summary>
        uint costSquareMeter;

        public House() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название здания</param>
        /// <param name="buildingPeriod">Период строительства</param>
        /// <param name="cost">Стоимость строительства</param>
        /// <param name="countCondo">Количество квартир</param>
        /// <param name="averageSquareMetersCondo">Среднее число м^2 в квартире</param>
        public House(string name, uint buildingPeriod, uint cost, uint countCondo, uint averageSquareMetersCondos) : base(name, buildingPeriod, cost)
        {
            this.countСondo = countCondo;
            this.averageSquareMetersCondos = averageSquareMetersCondos;
            // получение начальной стоимости квадратного метра
            costSquareMeter = GetPrimeCostPerSquareMeter();
        }

        /// <summary>
        /// Получение или установление количество квартир в доме
        /// </summary>
        public uint CountCondo
        {
            get
            {
                return countСondo;
            }
            set
            {
                if (countСondo == 0 && value != 0)
                {
                    countСondo = value;
                    if (cost != 0 && averageSquareMetersCondos != 0)
                    {
                        costSquareMeter = GetPrimeCostPerSquareMeter();
                    }
                }
            }
        }

        /// <summary>
        /// Получение или установление среднего количества м^2 в квартире
        /// </summary>
        public uint AverageSquareMetersCondos
        {
            get
            {
                return averageSquareMetersCondos;
            }
            set
            {
                if (averageSquareMetersCondos == 0 && value != 0)
                {
                    averageSquareMetersCondos = value;
                    if (cost != 0 && countСondo != 0)
                    {
                        costSquareMeter = GetPrimeCostPerSquareMeter();
                    }
                }
            }
        }

        /// <summary>
        /// Общее количество квартир
        /// </summary>
        public uint CountSoldCondos
        {
            get
            {
                return countSoldCondo;
            }
        }

        /// <summary>
        /// Получить количество не проданных квартир
        /// </summary>
        /// <returns></returns>
        public uint GetCountNotSoldCondos()
        {
            return countСondo - countSoldCondo;
        }

        /// <summary>
        /// Получение стоимости
        /// </summary>
        /// <returns></returns>
        public override uint GetCurCost()
        {
            // Если построенно
            if (IsBuild())
            {
                // , то стоимость зависит от не проданных квартир
                // кол-во не проданных кв. * среднее кол-во м^2 в кв. * себестоимость м^2
                return GetCountNotSoldCondos() * averageSquareMetersCondos * GetPrimeCostPerSquareMeter();
            }
            else
            {
                // , иначе стоимость затраченных средств
                return base.GetCurCost();
            }
        }

        /// <summary>
        /// Получить себестоимость квадратного метра
        /// </summary>
        /// <returns></returns>
        public uint GetPrimeCostPerSquareMeter()
        {
            // Стоимость / (количество кв. * среднее ков-во м^2 в кв.)
            return cost / (countСondo * averageSquareMetersCondos);
        }

        /// <summary>
        /// Продать квартиры
        /// </summary>
        /// <param name="count">Количество квартир</param>
        /// <returns>Сколько не продали квартир</returns>
        public uint PrimeCondos(uint count)
        {
            // Увеличиваем число проданых квартир
            countSoldCondo += count;
            // Если продали больше квартир чем нужно
            if (countSoldCondo > countСondo)
            {
                // , то такого не может быть
                // сохраняем разницу перебора проданных квартир
                uint razn = countSoldCondo - countСondo;
                // восстанавливаем баланс проданных и существующих
                countSoldCondo = countСondo;
                // возращаем количество непроданных квартир
                return razn;
            }
            // если квартир хватило, то продали все
            return 0;
        }

        /// <summary>
        /// Квартиры в доме продаются?
        /// </summary>
        /// <returns></returns>
        public bool AreTheApartmentsBeingSold()
        {
            return (countSoldCondo < countСondo);
        }

        /// <summary>
        /// Сделать копию объекта
        /// </summary>
        /// <returns></returns>
        public override Object Clone()
        {
            House clone = new House(name, buildingPeriod, cost,countСondo, averageSquareMetersCondos);
            clone.costMonth = CostMonth;
            clone.curBuildingPeriod = curBuildingPeriod;
            clone.freeze = freeze;
            clone.costSquareMeter = costSquareMeter;
            clone.countSoldCondo = countSoldCondo;
            return clone;
        }
    }
}
