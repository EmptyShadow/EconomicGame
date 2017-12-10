using System.Collections.Generic;
using EconomicGame.src.Economic.Buildings;

namespace EconomicGame.src
{
    /// <summary>
    /// Ядро приложения, в котором есть вся информация о настройках
    /// Список игроков.
    /// Ядро реализует шаблон проектирования Singleton
    /// </summary>
    public class Core
    {
        /// <summary>
        /// Текущий месяц
        /// </summary>
        static int curMonth = 1;

        /// <summary>
        /// Экземпляр ядра приложения
        /// </summary>
        static Core instance;

        /// <summary>
        /// Жилые дома доступные для постройки
        /// </summary>
        List<House> houses;

        /// <summary>
        /// Магазины доступные для постройки
        /// </summary>
        List<Market> markets;

        /// <summary>
        /// Настройки игрового процесса
        /// </summary>
        Settings settings;

        private Core(string nameSettings)
        {
            settings = ResourсesLoaderXML.LoadSettings(nameSettings);
            houses = ResourсesLoaderXML.LoadHavingsHouse();
            markets = ResourсesLoaderXML.LoadHavingsMarkets();
        }

        /// <summary>
        /// Получение экземпляра ядра
        /// </summary>
        public static Core Instanse
        {
            get
            {
                // Если ядро было загруженно
                if (instance != null)
                {
                    //, то вернуть его
                    return instance;
                }
                // иначе загрузить
                instance = new Core(ResourсesLoaderXML.DEF_SETTINGS);
                // и вернуть
                return instance;
            }
        }

        /// <summary>
        /// Получить настройки
        /// </summary>
        public Settings GetSettings
        {
            get
            {
                return settings;
            }
        }

        /// <summary>
        /// Получить на чтение список доступных жилых зданий
        /// </summary>
        public IReadOnlyCollection<Building> GetListHouses
        {
            get
            {
                return houses.AsReadOnly();
            }
        }

        /// <summary>
        /// Получить на чтение список доступных магазинов
        /// </summary>
        public IReadOnlyCollection<Building> GetListMarkets
        {
            get
            {
                return markets.AsReadOnly();
            }
        }

        /// <summary>
        /// Текущий месяц
        /// </summary>
        public int GetCurMonth
        {
            get
            {
                return curMonth;
            }
        }

        /// <summary>
        /// Текущий сезон
        /// </summary>
        public Seasons GetCurSeason
        {
            get
            {
                return Season.GetSeasonByNumMonth(curMonth);
            }
        }

        /// <summary>
        /// Перейти к следующему месяцу
        /// </summary>
        public void NextMonth()
        {
            curMonth++;
        }

        /// <summary>
        /// Отчистить ядро приложения
        /// </summary>
        public void Clear()
        {
            instance = null;
            settings = null;
            houses.Clear();
            houses = null;
            markets.Clear();
            markets = null;
        }
    }
}
