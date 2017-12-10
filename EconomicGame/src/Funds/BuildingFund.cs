using EconomicGame.src.Economic;

namespace EconomicGame.src.Funds
{
    /// <summary>
    /// Фонд по строительству зданий в микрорайоне
    /// </summary>
    public class BuildingFund
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
