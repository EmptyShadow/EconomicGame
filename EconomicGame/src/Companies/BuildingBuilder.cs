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
            foreach(Building building in capital.Things.Buildings)
            {

            }
        }

        /// <summary>
        /// Построить дом
        /// </summary>
        /// <param name="account">счет в банке</param>
        /// <param name="building">дом</param>
        private static void BuildBuilding(BankAccount account, Building building)
        {

        }
    }
}
