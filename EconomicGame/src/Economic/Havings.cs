using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomicGame.src.Economic.Buildings;
using System.Xml.Serialization;

namespace EconomicGame.src.Economic
{
    [Serializable]
    /// <summary>
    /// Имущество, собственность
    /// </summary>
    public class Havings
    {
        /// <summary>
        /// Здания входящие в имущество
        /// </summary>
        List<Building> buildings;

        /// <summary>
        /// Конструктор имущества, в котором ничего нет
        /// </summary>
        public Havings() {}

        /// <summary>
        /// Создать имущество с начальным списком зданий
        /// </summary>
        /// <param name="building"></param>
        public Havings(List<Building> building)
        {
            Building = building;
        }

        [XmlElement(Type = typeof(House)),
    XmlElement(Type = typeof(Market))]
        /// <summary>
        /// Получить или установить имущество
        /// </summary>
        public List<Building> Building
        {
            get
            {
                return GetCopyBuildings();
            }
            set
            {
                // Если еще не был определен список зданий
                if (buildings == null && value != null)
                {
                    //, то определяем его
                    buildings = new List<Building>();
                    foreach(Building building in value)
                    {
                        // получаем копии зданий, для того чтобы никто не мог изменить конфигурацию извне
                        // и получить более выгодное в игре здание
                        buildings.Add((Building)building.Clone());
                    }
                }
            }
        }

        public List<Building> GetCopyBuildings()
        {
            if (buildings == null) return null;
            List<Building> clone = new List<Buildings.Building>();
            foreach(Building b in buildings)
            {
                clone.Add((Building)b.Clone());
            }
            return clone;
        }

        /// <summary>
        /// Добавить здание в список
        /// </summary>
        /// <param name="building"></param>
        public void Add(Building building)
        {
            if (building == null) return;
            if (buildings == null)
            {
                buildings = new List<Building>();
            }
            buildings.Add(building);
        }

        /// <summary>
        /// Получить список зданий для чтения
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<Building> GetListBuildings()
        {
            // Вернуть колекцию списка для чтения
            return buildings.AsReadOnly();
        }
    }
}
