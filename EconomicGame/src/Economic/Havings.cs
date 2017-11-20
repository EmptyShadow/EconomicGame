using System.Collections.Generic;
using EconomicGame.src.Economic.Buildings;
using System.Windows;
using EconomicGame.src.Utils;

namespace EconomicGame.src.Economic
{
    /// <summary>
    /// Имущество, собственность
    /// </summary>
    public class Havings
    {
        /// <summary>
        /// Здания входящие в имущество,
        /// ключ - координаты в строковом представлении (x,y),
        /// значение - здание
        /// </summary>
        Dictionary<string, Building> buildings;

        /// <summary>
        /// Конструктор имущества, в котором ничего нет
        /// </summary>
        public Havings() {}

        /// <summary>
        /// Получить
        /// </summary>
        public Dictionary<string, Building>Building
        {
            get
            {
                return buildings;
            }
        }

        public Dictionary<string, Building> GetCopyBuildings()
        {
            if (buildings == null) return null;
            Dictionary<string, Building> clone = new Dictionary<string, Building>();
            foreach(KeyValuePair<string, Building> building in buildings)
            {
                clone.Add(building.Key, (Building)building.Value.Clone());
            }
            return clone;
        }

        /// <summary>
        /// Добавить здание в список
        /// </summary>
        /// <param name="p">Адрес здания</param>
        /// <param name="building"></param>
        public void Add(Point p, Building building)
        {
            if (building == null) return;
            if (buildings == null)
            {
                buildings = new Dictionary<string, Building>();
            }
            buildings.Add(ClassString.PointToString(p), building);
        }

        public uint GetAllSalesSquareMeters()
        {
            uint count = 0;
            foreach(KeyValuePair<string, Building> house in buildings)
            {
                House h = house.Value as House;
                if (h != null)
                {
                    count += h.AverageSquareMetersCondos * h.GetCountNotSoldCondos();
                }
            }
            return count;
        }
    }
}
