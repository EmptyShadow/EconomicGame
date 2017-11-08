using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Economic
{
    /// <summary>
    /// Капитал
    /// </summary>
    class Capital
    {
        /// <summary>
        /// Счет в банке, в котором лежат деньги
        /// </summary>
        public BankAccount Account { get; set; }

        /// <summary>
        /// Собственность, имущество
        /// </summary>
        public Havings Things { get; set; } 
    }
}
