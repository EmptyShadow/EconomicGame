using System;

namespace EconomicGame.src
{
    /// <summary>
    /// Вероятностное событие
    /// </summary>
    class ProbabilisticEvent
    {
        /// <summary>
        /// Благоприятное
        /// </summary>
        bool good = true;

        /// <summary>
        /// Нижняя граница
        /// </summary>
        int min = 0;

        /// <summary>
        /// Верхняя граница
        /// </summary>
        int max = 99;

        /// <summary>
        /// Генерация вероятностного события
        /// </summary>
        public ProbabilisticEvent()
        {
            good = GetProbabilisticResponce();
        }

        /// <summary>
        /// Получить случайный ответ
        /// </summary>
        /// <returns></returns>
        public bool GetProbabilisticResponce()
        {
            // Получаем генератор случайных чисел
            Random random = new Random();
            // получаем случайную величину
            double probabilisticVal = (random.Next(min, max) + random.NextDouble()) / (max - min + 1);
            // Обращаемся к ядру приложения для получения границы благоприятного события
            Core core = Core.Instanse;
            
            // Если случайное собыние меньше границы
            if (probabilisticVal < core.GetSettings.BorderFavorableOutcome)
            {
                //, то оно благоприятное
                return true;
            } else if (probabilisticVal > core.GetSettings.BorderFavorableOutcome)
            {
                // , иначе неблагоприятное
                return false;
            }
            // если они совпали, то пытаемся занова получить случайный ответ
            return GetProbabilisticResponce();
        }

        /// <summary>
        /// Благоприятное событие?
        /// </summary>
        public bool IsGood
        {
            get
            {
                return good;
            }
        }
    }
}
