using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EconomicGame.src.Utils
{
    /// <summary>
    /// Работа со строками
    /// </summary>
    class ClassString
    {
        /// <summary>
        /// Преобразовать точку к строке
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string PointToString(Point p)
        {
            return "(" + p.X.ToString() + "," + p.Y.ToString() + ")";
        }

        /// <summary>
        /// По строке получить точку
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static Point StringToPoint(string address)
        {
            try
            {
                address.Replace(" ", "");
                return new Point(Int32.Parse(address[1].ToString()), Int32.Parse(address[3].ToString()));
            } catch(Exception e)
            {
                return new Point(-1, -1);
            }

        }

        /// <summary>
        /// Получить путь к файлу с окончанием имени файла (имя класса + .xml)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetPathWithTypeAndXML<T>(string path, T obj)
        {
            // получаю название класса
            string nameT = GetNameClass(obj);
            // получаю позицию последней точки в пути к файлу
            int lastPoint = path.LastIndexOf('.');
            // получаю концовку строки после точки
            string xml = path.Substring(lastPoint);
            // Если в конце есть расширение файла
            if (xml == ".xml")
            {
                // то добавляем перед ним имя класса
                path = path.Substring(0, lastPoint + 1) + nameT + xml;
            }
            else
            {
                // иначе добавляем и имя класса и расширение класа
                path += "." + nameT + ".xml";
            }
            return path;
        }

        /// <summary>
        /// Получить имя Класса
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetNameClass<T>(T obj)
        {
            // получаем полное имя класса
            string nameT = obj.GetType().ToString().ToLower();
            return GetNameClass(nameT);
        }

        /// <summary>
        /// Получить имя класса
        /// </summary>
        /// <param name="fullPath"></param>
        /// <returns></returns>
        public static string GetNameClass(string fullPath)
        {
            // получаем позицию последней точки
            int lastPoint = fullPath.LastIndexOf('.');
            string name = fullPath.Substring(lastPoint + 1);
            if (name[name.Length - 1] == ']')
            {
                name = "collection." + name.Substring(0, name.Length - 1);
            }
            // извлекаю из полного имени краткое имя класса
            return name;
        }
    }
}
