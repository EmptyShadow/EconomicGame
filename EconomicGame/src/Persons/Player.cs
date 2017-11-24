using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomicGame.src.Economic.Buildings;

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
        public override void AddBuilding(Building building)
        {
            throw new NotImplementedException();
        }
    }
}
