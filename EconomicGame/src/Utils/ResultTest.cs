using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Utils
{
    /// <summary>
    /// Результат работы функции теста
    /// </summary>
    class ResultTest
    {
        /// <summary>
        /// Логический ответ, прошел тест успешно или нет
        /// </summary>
        public bool Answer { get; }
        /// <summary>
        /// Журнал информации о выполнении
        /// </summary>
        public string Logs { get; }

        /// <summary>
        /// Создать ответ теста
        /// </summary>
        /// <param name="answer">Результат прохождения теста</param>
        /// <param name="logs">Журнал прохождения теста</param>
        public ResultTest(bool answer, string logs)
        {
            Answer = answer;
            Logs = logs;
        }
    }
}
