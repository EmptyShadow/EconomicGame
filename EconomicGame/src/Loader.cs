using System;
using System.Xml;
using EconomicGame.src.Economic;

namespace EconomicGame.src
{
    /// <summary>
    /// Загрузчик ресурсов
    /// Зданий
    /// Настроек
    /// </summary>
    class ResourсesLoader
    {
        static string mainPathSettings = "./Resourсes/settings.xml";

        public static Settings LoadSettings()
        {
            // Создаем объект XML файла
            XmlDocument xSettings = new XmlDocument();
            // Загружаем в него файл с настройками
            xSettings.Load(mainPathSettings);
            // Получаем корень файла
            XmlElement xRoot = xSettings.DocumentElement;
            Settings settings;
            try
            {
                // Пытаемся найти все поля настроек
                settings = new Settings(
                    GetCountUsers(xRoot),
                    GetCountStaps(xRoot),
                    GetStartedCapital(xRoot),
                    GetDemand(xRoot),
                    GetLevelSalesStore(xRoot),
                    GetCoefsSeasons(xRoot),
                    GetBorderFavorableOutcome(xRoot)
                    );
            } catch (Exception e)
            {
                throw new Exception("В " + mainPathSettings + " ошибка: " + e.Message);
            }
            return settings;
        }

        /// <summary>
        /// Получить значение атрибута countUsers
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        static uint GetCountUsers(XmlElement element)
        {
            // Пытаемся получить значения в поле количестов игроков
            uint countUsers = UInt32.Parse(element.GetAttribute("countUsers"));
            return countUsers;
        }

        /// <summary>
        /// Получить значение атрибута countStaps
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        static uint GetCountStaps(XmlElement element)
        {
            uint countStaps = UInt32.Parse(element.GetAttribute("countStaps"));
            return countStaps;
        }

        /// <summary>
        /// Получить значение атрибута startedCapital
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        static uint GetStartedCapital(XmlElement element)
        {
            // Пытаемся получить значения в поле количестов игроков
            uint capital = UInt32.Parse(element.GetAttribute("startedCapital"));
            return capital;
        }

        /// <summary>
        /// Получение начального спроса
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        static Demand GetDemand(XmlElement element)
        {
            uint cost = 0;
            uint countSalesThings = 0;
            // получение элементов спроса
            foreach (XmlNode child in element.ChildNodes)
            {
                // элемент цены
                if (child.Name == "cost")
                {
                    cost = UInt32.Parse(child.InnerText);
                }
                // элемент количества
                else if (child.Name == "count")
                {
                    countSalesThings = UInt32.Parse(child.InnerText);
                }
            }
            return new Demand(cost, countSalesThings);
        }

        /// <summary>
        /// Получить значение атрибута levelSalesStore
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        static double GetLevelSalesStore(XmlElement element)
        {
            // Пытаемся получить значения в поле уровень продаж
            double levelSalesStore = Double.Parse(element.GetAttribute("levelSalesStore").Replace('.', ','));
            return levelSalesStore / 100.0;
        }

        /// <summary>
        /// Получение коэффициентов времен года
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        static double[] GetCoefsSeasons(XmlElement element)
        {
            double[] coefs = new double[4];
            coefs[(int)Seasons.Winter - 1] = Double.Parse(element.GetAttribute("winter").Replace('.', ','));
            coefs[(int)Seasons.Spring - 1] = Double.Parse(element.GetAttribute("spring").Replace('.', ','));
            coefs[(int)Seasons.Summer - 1] = Double.Parse(element.GetAttribute("summer").Replace('.', ','));
            coefs[(int)Seasons.Autumn - 1] = Double.Parse(element.GetAttribute("autumn").Replace('.', ','));
            return coefs;
        }

        /// <summary>
        /// Получить значение атрибута borderFavorableOutcome
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        static double GetBorderFavorableOutcome(XmlElement element)
        {
            // Пытаемся получить значения в поле границе благоприятных событий
            double borderFavorableOutcome = Double.Parse(element.GetAttribute("borderFavorableOutcome").Replace('.', ','));
            return borderFavorableOutcome % 1.0;
        }


    }
}
