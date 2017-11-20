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
        /// Реклама магазина 
        /// </summary>
        /// <param name="fund">Фонд</param>
        /// <param name="building">Здание</param>
        /// <param name="advertisingСosts">Затраты на рекламу здания</param>
        public static void AdvertisingMarket(BuildingFund fund, KeyValuePair<string, Building> market, uint advertisingСosts)
        {
            // Если здание принадлежит фонду
            if (fund.Capital.Things.Building[market.Key] == market.Value)
            {
                // Если магазин
                if ((market.Value as Market) != null)
                {
                    // Количество раз применения рекламы
                    uint countAdvertising = advertisingСosts / COST_PERCENTAGE_OF_INCREASE_IN_MARKET;
                    // Если размера затрат хватает на рекламу и платеж прошел
                    if (countAdvertising != 0 && fund.Capital.Account.Withdraw(countAdvertising * COST_PERCENTAGE_OF_INCREASE_IN_MARKET) != 0)
                    {
                        // , то увеличивает уровень продаж
                        ((Market)market.Value).MaxProfit = (uint)(((Market)market.Value).MaxProfit * (1 + countAdvertising * PERCENTAGE_OF_INCREASE_IN_MARKET));
                    }
                }
            }
        }

        /// <summary>
        /// Реклама жилья
        /// </summary>
        /// <param name="fund">Фонд</param>
        /// <param name="building">Здание</param>
        /// <param name="advertisingСosts">Затраты на рекламу здания</param>
        public static void AdvertisingHouse(BuildingFund fund, uint advertisingСosts)
        {
            // Количество раз применения рекламы
            uint countAdvertising = advertisingСosts / COST_PERCENTAGE_OF_SALES_OF_CONDO;
            // Если размера затрат хватает на рекламу и платеж прошел
            if (countAdvertising != 0 && fund.Capital.Account.Withdraw(countAdvertising * COST_PERCENTAGE_OF_SALES_OF_CONDO) != 0)
            {
                // , то увеличивает процент от рекламы
                fund.PercentageAdvertisingHouse = countAdvertising * PERCENTAGE_OF_SALES_OF_CONDO;
            }
        }
    }
}
