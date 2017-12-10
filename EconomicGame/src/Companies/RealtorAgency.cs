using System.Collections.Generic;
using EconomicGame.src.Funds;
using EconomicGame.src.Economic.Buildings;

namespace EconomicGame.src.Companies
{
    /// <summary>
    /// Риэлторское агентство, через которое происходит продажа квартир в жилых зданиях
    /// </summary>
    class RealtorAgency
    {
        /// <summary>
        /// Продать квартиры в микрорайоне
        /// </summary>
        /// <param name="fund"></param>
        public static void BuyCondos(BuildingFund fund)
        {
            // Получаем ядро с настройками
            Core core = Core.Instanse;
            // Количество кв. в продаже в продаже
            uint countAllSales = fund.Capital.Things.GetAllSalesSquareMeters();
            // Уровень продаж (количество возможно проданных кв. метров) в текущем месяце
            int countSalesSquareMetersInMonth = (int)(core.GetSettings.CountSalesSquareMetersInMonth * core.GetSettings.CoefsSeasonsHouse[(int)(core.GetCurSeason - 1)] * (1 + fund.PercentageAdvertisingHouse));
            fund.PercentageAdvertisingHouse = 0.0;

            // Если Предложение превышает или удволитворяет спрос
            if (countAllSales > countSalesSquareMetersInMonth)
            {
                // , то продажа начинается от дешевого до дорогого кв. м.
                // Множество квартир в микрорайоне сортированное по стоимости квадратного метра
                SortedSet<House> sortedHousesSetByCostSquareMeter = new SortedSet<House>();
                // Формируем сортированное множество обойдя все здания в микрорайоне
                foreach (KeyValuePair<string, Building> building in fund.Capital.Things.Building)
                {
                    // Если мы получим дом в котором продаются квартиры и его строительство не замороженно
                    House house = building.Value as House;
                    if (house != null && house.GetCountNotSoldCondos() != 0 && !house.IsFreeze)
                    {
                        // добавляем здание в сортированный список
                        sortedHousesSetByCostSquareMeter.Add(house);
                    }
                }

                // Продажа квартир в домах
                foreach(House house in sortedHousesSetByCostSquareMeter)
                {
                    if (countSalesSquareMetersInMonth == 0) break;

                    // Количество кв. м. в доме
                    uint countSquareMInHouse = house.AverageSquareMetersCondos * house.GetCountNotSoldCondos();
                    // Разность всего количества кв. м., которое будет проданно и кв.м. в доме
                    int raz = countSalesSquareMetersInMonth - (int)countSquareMInHouse;

                    // Если все кв. м. в доме будут проданы
                    if (raz >= 0)
                    {
                        // , то зачисляем полученные деньги за кв.м.
                        fund.Capital.Account.Deposite(countSquareMInHouse * house.CostSquareMeter);
                        // , вычитаем проданное количество кв.м. из общего кол-ва, которое будет проданно
                        countSalesSquareMetersInMonth -= (int)countSquareMInHouse;

                        // , продаем квартиры в доме
                        house.BuyCondos(house.GetCountNotSoldCondos());
                    } else
                    {
                        // , иначе продаем столько, сколько возможно продать
                        raz = -raz;
                        // Если ниодна квартира не продастся, то пропустить итерацию
                        if (raz < house.AverageSquareMetersCondos) continue;

                        // Количество проданных квартир
                        uint countBayCongos = (uint)(raz / house.AverageSquareMetersCondos);
                        // Количество проданных м^2
                        uint countBaySquareM = countBayCongos * house.AverageSquareMetersCondos;

                        // Зачисляем полученные от продажи деньги
                        fund.Capital.Account.Deposite(countBaySquareM * house.CostSquareMeter);
                        // Вычитаем кол-во проданных кв. м.
                        countSalesSquareMetersInMonth = raz - (int)(countBaySquareM);

                        // Продаем квартиры
                        house.BuyCondos(countBayCongos);
                    }
                }
            } else
            {
                // нужно выровнить цены
            }
        }
    }
}
