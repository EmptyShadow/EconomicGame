using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override void AddBuilding()
        {
            throw new NotImplementedException();
        }
    }
}
