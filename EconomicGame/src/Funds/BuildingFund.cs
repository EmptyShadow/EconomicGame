using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomicGame.src.Economic;

namespace EconomicGame.src.Funds
{
    /// <summary>
    /// Фонд по строительству зданий в микрорайоне
    /// </summary>
    class BuildingFund
    {
        /// <summary>
        /// Капитал фонда
        /// </summary>
        Capital capital;

        /// <summary>
        /// Реклама жилья
        /// </summary>
        public double PercentageAdvertisingHouse { get; set; } = 0.0;

        public BuildingFund()
        {
            capital = new Capital();
        }

        /// <summary>
        /// Получить капитал
        /// </summary>
        public Capital Capital
        {
            get
            {
                return capital;
            }
        }
    }
}
