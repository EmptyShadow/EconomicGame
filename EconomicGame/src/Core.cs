using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src
{
    /// <summary>
    /// Ядро приложения, в котором есть вся информация о настройках
    /// Список игроков.
    /// Ядро реализует шаблон проектирования Singleton
    /// </summary>
    class Core
    {
        /// <summary>
        /// Экземпляр ядра приложения
        /// </summary>
        private static Core instance;

        private Core()
        {
            
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
                instance = new Core();
                // и вернуть
                return instance;
            }
        }
    }
}
