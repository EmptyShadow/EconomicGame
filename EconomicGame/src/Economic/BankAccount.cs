using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Economic
{
    /// <summary>
    /// Банковский счет
    /// </summary>
    class BankAccount
    {
        /// <summary>
        /// Баланс
        /// </summary>
        private decimal accBal;

        public BankAccount()
        {
            accBal = 0;
        }

        /// <summary>
        /// Получить баланс
        /// </summary>
        public decimal Balance
        {
            get
            {
                return accBal;
            }
        }
    }
}
