using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Persons
{
    /// <summary>
    /// Игрок, за которого играет компьютер, и который является управляющим фондом
    /// </summary>
    class Bot : FundManager
    {
        /// <summary>
        /// Номер нового бота
        /// </summary>
        static int numberNextBot = 0;

        /// <summary>
        /// Создать нового бота
        /// </summary>
        public Bot() : base("Bot " + numberNextBot++) { }

        /// <summary>
        /// Добавить случайное здание
        /// </summary>
        public void AddBuilding()
        {
            //base.AddBuilding();
        }
    }
}
