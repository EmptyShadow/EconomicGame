using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomicGame.src.Economic;
using System.Reflection;

namespace EconomicGame.src
{
    /// <summary>
    /// Настройки игрового процесса
    /// </summary>
    class Settings
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
        /// Обычный уровень продаж в магазинах
        /// </summary>
        double levelSalesMarket;

        /// <summary>
        /// Коэффициенты сезонов
        /// </summary>
        double[] coefsSeasons;

        /// <summary>
        /// Граница благоприятного события
        /// </summary>
        double borderFavorableOutcome;

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
            double[] coefsSeasons, 
            double borderFavorableOutcome)
        {
            this.countPlayers = countPlayers;
            this.countStaps = countStaps;
            this.startCapital = startCapital;
            this.ordinaryDemandHouse = ordinaryDemandHouse;
            this.levelSalesMarket = levelSalesMarket;
            this.coefsSeasons = coefsSeasons;
            this.borderFavorableOutcome = borderFavorableOutcome;
            // Проверяю все ли поля заполнены
            string emptyAtr = GetEmptyAtributes();
            if (emptyAtr != "")
            {
                throw new Exception("Отсутствуют: " + emptyAtr);
            }
        }

        /// <summary>
        /// Получение коэффициента благоприятного события
        /// </summary>
        public double BorderFavorableOutcome
        {
            get
            {
                return borderFavorableOutcome;
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
            emptyArt.Remove(emptyArt.Length - 1);
            return emptyArt;
        }
    }
}
