using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomicGame.src.Economic;
using EconomicGame.src.Economic.Buildings;
using EconomicGame.src.Funds;

namespace EconomicGame.src.Companies
{
    /// <summary>
    /// Агенство по рекламе
    /// </summary>
    class AdvertisingAgency
    {
        /// <summary>
        /// Процент на который увеличивается уровень продаж квартир после рекламы
        /// </summary>
        public const double PERCENTAGE_OF_SALES_OF_CONDO = 0.005;
        /// <summary>
        /// Цена рекламы за процент увеличения уровня продаж квартир
        /// </summary>
        public const uint COST_PERCENTAGE_OF_SALES_OF_CONDO = 1000;
        /// <summary>
        /// Процент на который увеличивается прибыль в магазинах после рекламы
        /// </summary>
        public const double PERCENTAGE_OF_INCREASE_IN_MARKET = 0.03;
        /// <summary>
        /// Цена рекламы за процент увеличения прибыли в магазинах
        /// </summary>
        public const uint COST_PERCENTAGE_OF_INCREASE_IN_MARKET = 500;
        /// <summary>
        /// Реклама здания 
        /// </summary>
        /// <param name="fund">Фонд</param>
        /// <param name="building">Здание</param>
        /// <param name="advertisingСosts">Затраты на рекламу здания</param>
        public static void AdvertisingBuilding(BuildingFund fund, KeyValuePair<string, Building> building, uint advertisingСosts)
        {
            // Если здание принадлежит фонду
            if (fund.Capital.Things.Building[building.Key] == building.Value)
            {
                // , то Если это жилой дом
                if ((building.Value as House) != null)
                {
                    // Количество раз применения рекламы
                    uint countAdvertising = advertisingСosts / COST_PERCENTAGE_OF_SALES_OF_CONDO;
                    // Если размера затрат хватает на рекламу и платеж прошел
                    if (countAdvertising != 0 && fund.Capital.Account.Withdraw(countAdvertising * COST_PERCENTAGE_OF_SALES_OF_CONDO) != 0)
                    {
                        // , то увеличивает процент от рекламы
                        building.Value.PercentageAdvertising = countAdvertising * PERCENTAGE_OF_SALES_OF_CONDO;
                    }
                }
                // , иначе Если магазин
                if ((building.Value as Market) != null)
                {
                    // Количество раз применения рекламы
                    uint countAdvertising = advertisingСosts / COST_PERCENTAGE_OF_INCREASE_IN_MARKET;
                    // Если размера затрат хватает на рекламу и платеж прошел
                    if (countAdvertising != 0 && fund.Capital.Account.Withdraw(countAdvertising * COST_PERCENTAGE_OF_INCREASE_IN_MARKET) != 0)
                    {
                        // , то увеличивает процент от рекламы
                        building.Value.PercentageAdvertising = countAdvertising * PERCENTAGE_OF_INCREASE_IN_MARKET;
                    }
                }
            }
        }
    }
}
