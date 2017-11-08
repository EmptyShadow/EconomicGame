using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Economic.Buildings
{
    /// <summary>
    /// Жилой дом
    /// </summary>
    class House : Building
    {
        public House(string name, uint buildingPeriod, uint cost) : base(name, buildingPeriod, cost)
        {

        }
    }
}
