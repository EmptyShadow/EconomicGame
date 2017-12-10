using System.Collections.Generic;
using EconomicGame.src.Economic.Buildings;
using EconomicGame.src.Companies;

namespace EconomicGame.src.Persons
{
    /// <summary>
    /// Игрок, который является управляющим фондом в игре
    /// </summary>
    class Player : FundManager
    {
        /// <summary>
        /// Создать нового игрока
        /// </summary>
        /// <param name="name"></param>
        public Player(string name) : base(name) { }

        /// <summary>
        /// Добавить здание
        /// </summary>
        /// <param name="building"></param>
        public override void AddBuilding(KeyValuePair<System.Windows.Point, Building> building)
        {
            BuildingBuilder.ApproveTheBuilding(Fund, building);
        }
    }
}
