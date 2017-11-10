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
        /// <summary>
        /// Обычный спрос на квартиры
        /// </summary>
        Demand ordinaryDemandHouse;

        /// <summary>
        /// Обычный уровень продаж в магазинах
        /// </summary>
        double levelSalesMarket;

        /// <summary>
        /// Коэффициенты сезонов
        /// </summary>
        double[] coefsSeasons;

        /// <summary>
        /// Граница благоприятного события
        /// </summary>
        double borderFavorableOutcome;

        /// <summary>
        /// Создать настройки
        /// </summary>
        /// <param name="ordinaryDemandHouse">Обычный спрос на квартиры</param>
        /// <param name="levelSalesMarket">Обычный уровень продаж в магазинах</param>
        /// <param name="coefsSeasons">Коэффициенты сезонов</param>
        /// <param name="borderFavorableOutcome">Граница благоприятного события</param>
        public Settings(Demand ordinaryDemandHouse, double levelSalesMarket, double[] coefsSeasons, double borderFavorableOutcome)
        {
            this.ordinaryDemandHouse = ordinaryDemandHouse;
            this.levelSalesMarket = levelSalesMarket;
            this.coefsSeasons = coefsSeasons;
            this.borderFavorableOutcome = borderFavorableOutcome;
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
