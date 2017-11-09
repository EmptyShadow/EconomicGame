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
        BankAccount account;

        /// <summary>
        /// Собственность, имущество
        /// </summary>
        Havings things;

        public Capital()
        {
            // Создаем счет в банке
            account = new BankAccount();
            // Создаем списки имущества
            things = new Havings();
        }

        public BankAccount Account
        {
            get
            {
                return account;
            }
        }

        public Havings Things
        {
            get
            {
                return things;
            }
        }
    }
}
