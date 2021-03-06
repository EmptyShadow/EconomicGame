﻿using EconomicGame.src.Economic.Buildings;
using System.Collections.Generic;

namespace EconomicGame.src.Economic
{
    /// <summary>
    /// Капитал
    /// </summary>
    public class Capital
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

        /// <summary>
        /// Получить счет в банке
        /// </summary>
        public BankAccount Account
        {
            get
            {
                return account;
            }
        }

        /// <summary>
        /// Получить имущество
        /// </summary>
        public Havings Things
        {
            get
            {
                return things;
            }
        }

        /// <summary>
        /// Полная стоимость капитала
        /// </summary>
        /// <returns></returns>
        public uint CostCapital()
        {
            // деньги от продаж
            uint cost = account.Balance;
            // стоимость не построиных зданий, стоимости непроданных квартир в построенных домах и стоимость построенных магазинов
            foreach (KeyValuePair<string, Building> building in things.Building)
            {
                cost += building.Value.GetCurCost();
            }
            return cost;
        }

        /// <summary>
        /// Получить карту магазинов
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Building> GetMarkets()
        {
            Dictionary<string, Building> list = new Dictionary<string, Building>();
            foreach(KeyValuePair<string, Building> building in Things.Building)
            {
                if (building.Value as Market != null)
                {
                    list.Add(building.Key, building.Value);
                }
            }
            return list;
        }
    }
}
