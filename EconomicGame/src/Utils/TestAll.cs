using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicGame.src.Utils
{
    /// <summary>
    /// Тест на всех доступных тестах
    /// </summary>
    class TestAll : ITest
    {
        /// <summary>
        /// Делегат на функию теста
        /// </summary>
        /// <returns></returns>
        public delegate ResultTest RunUserTest();

        /// <summary>
        /// Список тестов
        /// </summary>
        protected static List<RunUserTest> listTests = new List<RunUserTest>();

        public void Add(RunUserTest func)
        {
            listTests.Add(func);
        }

        /// <summary>
        /// Запустить тест
        /// </summary>
        /// <returns></returns>
        public virtual ResultTest Run()
        {
            bool answer = true;
            string logs = this.GetType().ToString();
            foreach (RunUserTest funcTest in listTests)
            {
                try
                {
                    ResultTest restTest = funcTest();
                    answer = answer && restTest.Answer;
                    WriteStringInLogs(logs, restTest.Logs);
                } catch (Exception e)
                {
                    logs += "\n" + funcTest.GetMethodInfo().Name;
                    WriteStringInLogs(logs, e.Message);
                }
            }
            return new ResultTest(answer, logs);
        }

        /// <summary>
        /// Записать строку в журнал
        /// </summary>
        /// <param name="logs">Журнал</param>
        /// <param name="s">Строка для записи</param>
        /// <returns>Новый журнал</returns>
        protected static string WriteStringInLogs(string logs, string s)
        {
            string newLine = "\n";
            if (logs == "")
            {
                newLine = "";
            }
            if (s == "")
            {
                return logs;
            }
            return logs + newLine + 
                "-->" + s.Substring(0, 1).ToUpper() + s.Substring(1);
        }
    }
}
