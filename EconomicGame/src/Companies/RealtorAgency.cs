using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            // Множество квартир в микрорайоне сортированное по стоимости квадратного метра
            SortedSet<House> sortedHousesSetByCostSquareMeter = new SortedSet<House>();
            // Формируем сортированное множество обойдя все здания в микрорайоне
            foreach (KeyValuePair<string, Building> building in fund.Capital.Things.Building)
            {
                House house = building.Value as House;
                //if (house != null && )
            }
        }
    }
}
