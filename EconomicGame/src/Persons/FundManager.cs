using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EconomicGame.src.Funds; // фонды

namespace EconomicGame.src.Persons
{
    /// <summary>
    /// Управляющий фондом
    /// </summary>
    class FundManager
    {
        /// <summary>
        /// Имя управляющего
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фонд, которым управляет управляющий
        /// </summary>
        public BuildingFund Fund { get; set; }


    }
}
