using System;
using System.Xml;
using EconomicGame.src.Economic;
using System.Xml.Serialization;
using System.IO;

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

        /// <summary>
        /// Загрузка настроек игрового процесса
        /// </summary>
        /// <param name="path">Путь к файлу настроек</param>
        /// <returns></returns>
        public static Settings LoadSettings(string path)
        {
            // Сериализация в формате XML для типа данных Settings
            XmlSerializer formatter = new XmlSerializer(typeof(Settings));

            // Переменная, в которую будут помещенны настройки
            Settings settings = null;

            // Пытаемся получить настройки из потока файла
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                settings = (Settings)formatter.Deserialize(fs);
            }
            return settings;
        }

        /// <summary>
        /// Загрузка настроек игрового процесса по умолчанию
        /// </summary>
        /// <returns></returns>
        public static Settings LoadSettings()
        {
            return LoadSettings(mainPathSettings);
        }

        /// <summary>
        /// Сохранить настройки
        /// </summary>
        /// <param name="path">Путь к существующему или новому файлу</param>
        /// <param name="settings">Настройки</param>
        public static void SaveSettings(string path, Settings settings)
        {
            // Сериализация в формате XML для типа данных Settings
            XmlSerializer formatter = new XmlSerializer(typeof(Settings));

            // Используем новый поток файла для записи объекта настроек
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, settings);
            }
        }

    }
}
