using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomicGame.src.Economic.Buildings;

namespace EconomicGame.src.Economic
{
    /// <summary>
    /// Имущество, собственность
    /// </summary>
    class Havings
    {
        /// <summary>
        /// Здания входящие в имущество
        /// </summary>
        List<Building> buildings;

        /// <summary>
        /// Конструктор пустого имущества
        /// </summary>
        public Havings()
        {
            // Создаем списко зданий
            buildings = new List<Building>();
        }

        /// <summary>
        /// Добавить здание в список
        /// </summary>
        /// <param name="building"></param>
        public void Add(Building building)
        {
            buildings.Add(building);
        }

        /// <summary>
        /// Получить список зданий для чтения
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<Building> ReadListBuildings()
        {
            // Вернуть колекцию списка для чтения
            return buildings.AsReadOnly();
        }
    }
}
