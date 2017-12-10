using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using EconomicGame.src.Economic.Buildings;
using EconomicGame.src.Utils;

namespace EconomicGame.src
{
    /// <summary>
    /// Загрузчик ресурсов
    /// Зданий
    /// Имущества
    /// Любого объекта для сереализации
    /// </summary>
    class ResourсesLoaderXML
    {
        /// <summary>
        /// Директория файлов xml
        /// </summary>
        public const string RESOURCES = "./Resourсes/";
        /// <summary>
        /// Директория файлов xml
        /// </summary>
        public const string SETTINGS = "Settings/";
        /// <summary>
        /// Директория имущества
        /// </summary>
        public const string BUILDINGS = "Buildings/";
        /// <summary>
        /// Имя файла настроек по умолчанию
        /// </summary>
        public const string DEF_SETTINGS = "default.settings";
        /// <summary>
        /// Имя файла имущества жилых зданий по умолчанию
        /// </summary>
        public const string DEF_HOUSES = "default.houses.collection.house";
        /// <summary>
        /// Имя файла имущества магазинов по умолчанию
        /// </summary>
        public const string DEF_MARKETS = "default.markets.collection.market";

        /// <summary>
        /// Загрузка из файла xml
        /// </summary>
        /// <typeparam name="T">Тип объекта загрузки</typeparam>
        /// <param name="name">Имя файла относительно Resources</param>
        /// <returns></returns>
        public static T Load<T>(string name)
        {
            string path = RESOURCES + name + ".xml";
            // Сериализация в формате XML для типа данных T
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            // Переменная, в которую будут помещенны поля T
            T type;

            // Пытаемся получить настройки из потока файла
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                type = (T)formatter.Deserialize(fs);
            }
            return type;
        }

        /// <summary>
        /// Сохранение файла xml
        /// </summary>
        /// <typeparam name="T">Тип объекта сохранения</typeparam>
        /// <param name="name">Имя файла относительно Recources</param>
        /// <param name="obj">Объект сохранения</param>
        public static void Save<T>(string name, T obj)
        {
            // Сериализация в формате XML для типа данных T
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            // дополняю путь к файлу расширение и именем объекта
            string path = RESOURCES + name + "." + ClassString.GetNameClass(obj) + ".xml";

            // Используем новый поток файла для записи объекта
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, obj);
            }
        }

        /// <summary>
        /// Загрузка настроек игрового процесса
        /// </summary>
        /// <param name="path">Путь к файлу настроек</param>
        /// <returns></returns>
        public static Settings LoadSettings(string name)
        {
            return Load<Settings>(SETTINGS + name);
        }

        /// <summary>
        /// Загрузка настроек игрового процесса по умолчанию
        /// </summary>
        /// <returns></returns>
        public static Settings LoadSettings()
        {
            return Load<Settings>(SETTINGS + DEF_SETTINGS);
        }

        /// <summary>
        /// Сохранить настройки
        /// </summary>
        /// <param name="path">Имя файла относительно Resources</param>
        /// <param name="settings">Настройки</param>
        public static void SaveSettings(string name, Settings settings)
        {
            Save(SETTINGS + name, settings);
        }

        /// <summary>
        /// Сохранить настройки поумолчанию
        /// </summary>
        /// <param name="settings">Настройки</param>
        public static void SaveSettings(Settings settings)
        {
            Save(SETTINGS + "default", settings);
        }

        /// <summary>
        /// Получить список жилых домов доступных в игре по умолчанию
        /// </summary>
        /// <returns></returns>
        public static List<House> LoadHavingsHouse()
        {
            return Load<List<House>>(BUILDINGS + DEF_HOUSES);
        }

        /// <summary>
        /// Сохранить имущество жилых зданий по умолчанию
        /// </summary>
        /// <param name="houses"></param>
        public static void SaveHavingsHouse(List<House> houses)
        {
            Save(BUILDINGS + "default.houses", houses);
        }

        /// <summary>
        /// Сохранить имущество магазинов по умолчанию
        /// </summary>
        /// <param name="houses"></param>
        public static void SaveHavingsMarket(List<Market> markets)
        {
            Save(BUILDINGS + "default.markets", markets);
        }

        /// <summary>
        /// Получить список магазинов доступных в игре по умолчанию
        /// </summary>
        /// <returns></returns>
        public static List<Market> LoadHavingsMarkets()
        {
            return Load<List<Market>>(BUILDINGS + DEF_MARKETS);
        }

        /*/// <summary>
        /// Загрузить имущество из файла XML
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Havings LoadHavings(string name)
        {
            return Load<Havings>(BUILDINGS + name);
        }

        /// <summary>
        /// Сохранить имущество в файл XML
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static void SaveHavings(string name, Havings havings)
        {
            Save(BUILDINGS + name, havings);
        }*/
    }
}
