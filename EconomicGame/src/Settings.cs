using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomicGame.src.Economic;
using System.Reflection;

namespace EconomicGame.src
{
    [Serializable]
    /// <summary>
    /// Настройки игрового процесса
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// Количество игроков
        /// </summary>
        uint countPlayers;

        /// <summary>
        /// Продолжтельность игры(количество шагов)
        /// </summary>
        uint countStaps;

        /// <summary>
        /// Стартовый капитал
        /// </summary>
        uint startCapital;

        /// <summary>
        /// Обычный спрос на квартиры
        /// </summary>
        Demand ordinaryDemandHouse;

        /// <summary>
        /// Обычное количество проданных квартир в месяц в микрорайоне
        /// </summary>
        uint countSalesSquareMetersInMonth;

        /// <summary>
        /// Обычный уровень продаж в магазинах
        /// </summary>
        double levelSalesMarket;

        /// <summary>
        /// Коэффициенты сезонов при продаже квартир
        /// </summary>
        double[] coefsSeasonsHouse;

        /// <summary>
        /// Коэффициенты сезонов при продаже в магазинах
        /// </summary>
        double[] coefsSeasonsMarket;

        /// <summary>
        /// Граница благоприятного события
        /// </summary>
        double borderFavorableOutcome;

        public Settings() { }

        /// <summary>
        /// Создать настройки
        /// </summary>
        /// <param name="countPlayers">Количество игроков</param>
        /// <param name="countStaps">Продолжтельность игры(количество шагов)</param>
        /// <param name="startCapital">Стартовый капитал</param>
        /// <param name="ordinaryDemandHouse">Обычный спрос на квартиры</param>
        /// <param name="levelSalesMarket">Обычный уровень продаж в магазинах</param>
        /// <param name="coefsSeasons">Коэффициенты сезонов</param>
        /// <param name="borderFavorableOutcome">Граница благоприятного события</param>
        public Settings(uint countPlayers, 
            uint countStaps,
            uint startCapital, 
            Demand ordinaryDemandHouse, 
            double levelSalesMarket, 
            double[] coefsSeasonsHouse,
            double[] coefsSeasonsMarket,
            double borderFavorableOutcome)
        {
            this.countPlayers = countPlayers;
            this.countStaps = countStaps;
            this.startCapital = startCapital;
            this.ordinaryDemandHouse = ordinaryDemandHouse;
            this.levelSalesMarket = levelSalesMarket;
            this.coefsSeasonsHouse = coefsSeasonsHouse;
            this.coefsSeasonsMarket = coefsSeasonsMarket;
            this.borderFavorableOutcome = borderFavorableOutcome;
            // Проверяю все ли поля заполнены
            string emptyAtr = GetEmptyAtributes();
            if (emptyAtr != "")
            {
                throw new Exception("Отсутствуют: " + emptyAtr);
            }
        }

        /// <summary>
        /// Получить или установить количество игроков
        /// </summary>
        public uint CountPlayers
        {
            get
            {
                return countPlayers;
            }
            set
            {
                if (countPlayers == 0 && value != 0)
                {
                    countPlayers = value;
                }
            }
        }

        /// <summary>
        /// Получить или установить продолжтельность игры(количество шагов)
        /// </summary>
        public uint CountStaps
        {
            get
            {
                return countStaps;
            }
            set
            {
                if (countStaps == 0 && value != 0)
                {
                    countStaps = value;
                }
            }
        }

        /// <summary>
        /// Получить или установить стартовый капитал
        /// </summary>
        public uint StartCapital
        {
            get
            {
                return startCapital;
            }
            set
            {
                if (startCapital == 0 && value != 0)
                {
                    startCapital = value;
                }
            }
        }

        /// <summary>
        /// Получить или установить обычный спрос на квартиры
        /// </summary>
        public Demand OrdinaryDemandHouse
        {
            get
            {
                return ordinaryDemandHouse;
            }
            set
            {
                if (ordinaryDemandHouse == null && value != null)
                {
                    ordinaryDemandHouse = value;
                }
            }
        }

        /// <summary>
        /// Обычное количество проданных квартир в месяц
        /// </summary>
        public uint CountSalesSquareMetersInMonth
        {
            get
            {
                return countSalesSquareMetersInMonth;
            }
            set
            {
                if (countSalesSquareMetersInMonth == 0 && value != 0)
                {
                    countSalesSquareMetersInMonth = value;
                }
            }
        }

        /// <summary>
        /// Получить или установить обычный уровень продаж в магазинах
        /// </summary>
        public double LevelSalesMarket
        {
            get
            {
                return levelSalesMarket;
            }
            set
            {
                if (levelSalesMarket == 0.0 && value != 0.0)
                {
                    levelSalesMarket = value;
                }
            }
        }

        /// <summary>
        /// Получить или установить коэффициенты сезонов
        /// </summary>
        public double[] CoefsSeasonsHouse
        {
            get
            {
                return coefsSeasonsHouse;
            }
            set
            {
                if (coefsSeasonsHouse == null && value != null && value.Length == 4)
                {
                    coefsSeasonsHouse = value;
                }
            }
        }

        /// <summary>
        /// Получить или установить коэффициенты сезонов
        /// </summary>
        public double[] CoefsSeasonsMarket
        {
            get
            {
                return coefsSeasonsMarket;
            }
            set
            {
                if (coefsSeasonsMarket == null && value != null && value.Length == 4)
                {
                    coefsSeasonsMarket = value;
                }
            }
        }

        /// <summary>
        /// Получение или установление коэффициента благоприятного события
        /// </summary>
        public double BorderFavorableOutcome
        {
            get
            {
                return borderFavorableOutcome;
            }
            set
            {
                if (borderFavorableOutcome == 0.0 && value != 0.0)
                {
                    borderFavorableOutcome = value;
                }
            }
        }

        /// <summary>
        /// Получить список пустых полей
        /// </summary>
        /// <returns>имена полей</returns>
        string GetEmptyAtributes()
        {
            string emptyArt = "";
            // массив полей класса
            FieldInfo[] myFieldInfo;
            // получаю тип класса Settings
            Type myType = typeof(Settings);
            // Получаю не публичные поля, поля экземпляров и публичные поля типа Settings
            myFieldInfo = myType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance
                | BindingFlags.Public);
            // Прохожу поля и определяю какие из них не инициализированны значением
            foreach (FieldInfo field in myFieldInfo)
            {
                if (field.GetValue(this) == null)
                {
                    // формирую строку имен полей, которые отсутствуют
                    emptyArt += field.Name + ",";
                }
            }

            // Удаляю последнюю запятую
            if (emptyArt != "") emptyArt.Remove(emptyArt.Length - 1);
            return emptyArt;
        }
    }
}
