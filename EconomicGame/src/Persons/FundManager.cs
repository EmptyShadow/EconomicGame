using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomicGame.src.Companies;
using EconomicGame.src.Economic.Buildings;
using EconomicGame.src;

using EconomicGame.src.Funds; // фонды

namespace EconomicGame.src.Persons
{
    /// <summary>
    /// Управляющий фондом
    /// </summary>
    abstract class FundManager
    {
        /// <summary>
        /// Имя управляющего
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Активность
        /// </summary>
        public bool Enable { get; set; }

        public bool Profit { get; set; } = false;

        public bool Payment { get; set; } = false;
        
        /// <summary>
        /// Фонд, которым управляет управляющий
        /// </summary>
        public BuildingFund Fund { get; }

        /// <summary>
        /// Создать нового игрока
        /// </summary>
        /// <param name="name"></param>
        public FundManager(string name)
        {
            Name = name;
            // Нового пользователя блокируем пока не настанет его очередь ходить
            Enable = false;
        }
        
        /// <summary>
        /// Получить прибыль от продажи квадратных метров и прибыль из магазинов
        /// </summary>
        public void MakeProfit()
        {
            MakeProfitTheSaleSquareMeters();
            MakeProfitTheSaleInMarkets();
        }

        /// <summary>
        /// Получить прибыль от продажи квадратных метров
        /// </summary>
        public void MakeProfitTheSaleSquareMeters()
        {
            RealtorAgency.BuyCondos(Fund);
        }

        /// <summary>
        /// Получить прибыль от продажи в магазинах
        /// Учитываются проценты
        /// 1) сезон года
        /// 2) соседние жилые здания
        /// </summary>
        public void MakeProfitTheSaleInMarkets()
        {
            // Получаем ядро с настройками
            Core core = Core.Instanse;
            // Проходим все магазины и собираем прибыль
            foreach(KeyValuePair<string, Building> marketKV in Fund.Capital.Things.Building)
            {
                Market market = marketKV.Value as Market;
                // Если мы зашли в магазин
                if (market != null)
                {
                    // Возможна прибыль
                    uint profit = market.MaxProfit;

                    // Учитываем процент сезона года
                    profit = (uint)(profit * core.GetSettings.CoefsSeasonsMarket[(int)core.GetCurSeason]);

                    // Учитываем процент соседей
                    profit = (uint)(profit * market.CountNeighbors / 8.0);

                    // Закидываем прибыль от магазина на счет в банке
                    Fund.Capital.Account.Deposite(profit);
                }
            }
            // прибыль получена
            Profit = true;
        }

        /// <summary>
        /// Оплатить строительство зданий в текущем месяце
        /// </summary>
        public void BuilderPayment()
        {
            // Обращаемся к застройщику для стоительства зданий
            BuildingBuilder.Build(Fund);

            // Оплатили строительство
            Payment = true;
        }

        /// <summary>
        /// Закончить месяц (ход)
        /// </summary>
        public void FinishMonth()
        {
            Enable = false;
        }

        /// <summary>
        /// Начать месяц (ход)
        /// </summary>
        public void StartMonth()
        {
            Enable = true;
            Profit = false;
            Payment = false;
        }

        /// <summary>
        /// Добавить новое здание
        /// </summary>
        public abstract void AddBuilding();
    }
}
