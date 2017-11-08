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
        public List<Building> Buildings { get; set; }
    }
}
