using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomicGame.src.Economic;
using EconomicGame.src.Economic.Buildings;

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
        public static void Build(Capital capital)
        {
            // Проходим по всему списку зданий
            foreach(Building building in capital.Things.GetListBuildings())
            {
                // и пытаемся их построить
                BuildBuilding(capital.Account, building);
            }
        }

        /// <summary>
        /// Построить дом
        /// </summary>
        /// <param name="account">счет в банке</param>
        /// <param name="building">дом</param>
        private static void BuildBuilding(BankAccount account, Building building)
        {
            // Если здание не построенно и не замороженно и платеж от фонда прошел
            if (!building.IsBuild() && !building.IsFreeze && account.Withdraw(building.CostMonth) != 0)
            {
                // генерируем случайное событие
                ProbabilisticEvent probEvent = new ProbabilisticEvent();
                if (probEvent.IsGood)
                {
                    // , то построить
                    building.NextStageBuilding();
                }
            }
        }
    }
}
