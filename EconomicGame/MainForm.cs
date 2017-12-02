using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EconomicGame.src.Views;
using EconomicGame.src;
using EconomicGame.src.Economic.Buildings;
using EconomicGame.src.Persons;

namespace EconomicGame
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Стартовое меню
        /// </summary>
        private StartMenu startMenu;

        /// <summary>
        /// Ядро приложения
        /// </summary>
        private Core core;
        /// <summary>
        /// Список форм игроков
        /// </summary>
        private List<FundManagerPanel> listFundManagers = null;
        /// <summary>
        /// индекс текущего игрока
        /// </summary>
        int curFundManager = 0;        

        public MainForm()
        {
            InitializeComponent();
            Text = "Иметационная игра в строительство";

            startMenu = new StartMenu();
            startMenu.Name = "startMenu";
            startMenu.startButton = GetCore;
            startMenu.exitButton = Exit;
            startMenu.Visible = true;

            listFundManagers = new List<FundManagerPanel>();

            userControl.Controls.Add(startMenu);
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetCore(object core, EventArgs e)
        {
            this.core = core as Core;
            if (this.core != null)
            {
                startMenu.Visible = false;

                for (int i = 0; i < this.core.GetSettings.CountPlayers; i++)
                {
                    FundManagerPanel fundManager = new FundManagerPanel();
                    fundManager.Visible = false;
                    fundManager.Dock = DockStyle.Fill;
                    fundManager.NextMonth = HandlerNextMonth;
                    userControl.Controls.Add(fundManager);
                    listFundManagers.Add(fundManager);
                }

                listFundManagers[curFundManager].Visible = true;
            }
        }

        private void HandlerNextMonth()
        {
            curFundManager++;
            if (curFundManager >= listFundManagers.Count)
            {
                curFundManager = 0;
                core.NextMonth();
            }
            if (core.GetCurMonth > core.GetSettings.CountStaps)
            {
                EndGame();
                return;
            }
            listFundManagers[curFundManager].Visible = true;
        }

        private void EndGame()
        {
            uint maxCostCapital = 0;
            string name = "";

            foreach (FundManagerPanel panel in listFundManagers)
            {
                uint cost = panel.GetCostCapital();
                if (cost > maxCostCapital)
                {
                    maxCostCapital = cost;
                    name = panel.GetName();
                }
            }

            Label win = new Label();
            win.Dock = DockStyle.Fill;
            win.TextAlign = ContentAlignment.MiddleCenter;

            win.Text = "Капитал " + maxCostCapital + "\n" +
                name;

            userControl.Controls.Add(win);
        }
    }
}
