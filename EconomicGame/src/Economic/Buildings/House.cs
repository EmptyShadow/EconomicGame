using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Economic.Buildings
{
    /// <summary>
    /// Жилой дом
    /// </summary>
    class House : Building
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
    }
}
