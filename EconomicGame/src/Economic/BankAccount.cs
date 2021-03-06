﻿namespace EconomicGame.src.Economic
{
    /// <summary>
    /// Банковский счет
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Баланс
        /// </summary>
        private uint accBal;

        /// <summary>
        /// Баланс поумолчанию
        /// </summary>
        public BankAccount()
        {
            // Нулевой баланс
            accBal = 0;
        }

        /// <summary>
        /// Получить баланс
        /// </summary>
        public uint Balance
        {
            get
            {
                return accBal;
            }
        }

        /// <summary>
        /// Вложение средств
        /// </summary>
        /// <param name="deposite"></param>
        /// <returns>Новый баланс</returns>
        public uint Deposite(uint deposite)
        {
            // Делаем вклад
            accBal += deposite;
            // Сообщаем баланс
            return accBal;
        }

        /// <summary>
        /// Снять со счета деньги
        /// Вернется количество снятых сбережений или 0 если не достаточно средств
        /// </summary>
        /// <param name="bal"></param>
        /// <returns></returns>
        public uint Withdraw(uint bal)
        {
            // Если на счете достаточно средств
            if (accBal > bal)
            {
                // ,то снимаем
                accBal -= bal;
                // и выводим
                return bal;
            } else
            {
                // Иначе возвращаем 0
                return 0;
            }
        }

    }
}
