using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicGame.src.Views
{
    public partial class StartMenu : UserControl
    {
        public delegate void ClickButtons(object sender, EventArgs e);

        /// <summary>
        /// Обработчик нажания кнопки старт, в качестве объекта вернется ядро приложения
        /// </summary>
        public ClickButtons startButton = null;
        /// <summary>
        /// Обработчик выхода из приложения
        /// </summary>
        public ClickButtons exitButton = null;

        public StartMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработка кнопки старт и передача в делегат объекта загруженного ядра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Core core = Core.Instanse;

            startButton?.Invoke(core, e);
        }

        /// <summary>
        /// Вызов формы для изменения настроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormUpgradeSettings upgradeSettings = new FormUpgradeSettings();
            upgradeSettings.ShowDialog();
        }

        /// <summary>
        /// Обработчик передает делегату сообщение о том то нужно выйти из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitButton?.Invoke(sender, e);
        }
    }
}
