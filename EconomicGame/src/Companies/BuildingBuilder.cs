using System;
using System.Collections.Generic;
using EconomicGame.src.Economic;
using EconomicGame.src.Economic.Buildings;
using EconomicGame.src.Funds;
using System.Windows;
using EconomicGame.src.Utils;

namespace EconomicGame.src.Companies
{
    /// <summary>
    /// Подрядчик, который строит дома в микрорайоне
    /// </summary>
    class BuildingBuilder
    {
        /// <summary>
        /// Построить дома
        /// </summary>
        /// <param name="capital">Капитал фонда</param>
        public static void Build(BuildingFund fund)
        {
            // Проходим по всему списку зданий
            foreach(KeyValuePair<string, Building> building in fund.Capital.Things.Building)
            {
                // и пытаемся их построить
                BuildBuilding(fund.Capital.Account, building.Value);
            }
        }

        /// <summary>
        /// Построить дом
        /// </summary>
        /// <param name="account">счет в банке</param>
        /// <param name="building">дом</param>
        private static void BuildBuilding(BankAccount account, Building building)
        {
            // Если здание не построенно и не замороженно его строительство и платеж от фонда прошел
            if (!building.IsBuild() && !building.IsFreeze && account.Withdraw(building.CostMonth) != 0)
            {
                // генерируем случайное событие
                ProbabilisticEvent probEvent = new ProbabilisticEvent();
                if (!probEvent.IsGood)
                {
                    // задержать строительство
                    building.DelayBuilding();
                }
                // перейти к новому месяцу
                building.NextStageBuilding();
            }
        }

        /// <summary>
        /// Одобрить проект строительства и внести его в журнал имущества компании
        /// </summary>
        /// <param name="fund"></param>
        /// <param name="building"></param>
        /// <returns></returns>
        public static bool ApproveTheBuilding(BuildingFund fund, KeyValuePair<Point, Building> building)
        {
            // Если на месте предполагаемой постройки нет здания
            try
            {
                Building b = fund.Capital.Things.Building[ClassString.PointToString(building.Key)];
                return false;
            } catch (Exception e)
            {
                // , то добавляем проект здания в журнал
                fund.Capital.Things.Add(building.Key, building.Value);
                // уведомляем соседей о будущей постройке
                for (int i = (int)building.Key.X - 1; i <= building.Key.X + 1; i++)
                    for (int j = (int)building.Key.Y - 1; j <= (int)building.Key.Y + 1; j++)
                    {
                        try
                        {
                            string p = ClassString.PointToString(new Point(i, j));
                            Building b = fund.Capital.Things.Building[p];
                            // Если сосед управляет другим бизнесом и он есть
                            if (b != null && b.GetType() != building.Value.GetType())
                            {
                                // , то уведомляем
                                b.CountNeighbors++;
                                building.Value.CountNeighbors++;
                            }
                        } catch (Exception exp)
                        {

                        }
                    }
                return true;
            }
        }
    }
}
