using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EconomicGame.src.Persons;

namespace EconomicGame.src.Views
{
    public partial class FundManagerPanel : UserControl
    {
        public delegate void Send();
        public Send NextMonth;

        Map map;
        FundManager manager;
        static int numPlayer = 0;
        
        public FundManagerPanel()
        {
            InitializeComponent();

            Manager = new Player("Игрок " + numPlayer++.ToString());

            map = new Map();
            map.Buildings = manager.Fund.Capital.Things;
            map.Dock = DockStyle.Fill;

            splitContainer.Panel1.Controls.Add(map);
        }

        public FundManager Manager
        {
            set
            {
                if (value != null)
                {
                    manager = value;
                    manager.Fund.Capital.Account.Deposite(Core.Instanse.GetSettings.StartCapital);
                    groupBoxPlayer.Text = manager.Name;
                    UpdatePlayerInfo();
                    UpdateInfoCore();
                }
            }
        }

        public void UpdatePlayerInfo()
        {
            labelBankAccountBalance.Text = "Баланс на счете в банке " + manager.Fund.Capital.Account.Balance.ToString();
            labelCapital.Text = "Стоимость капитала " + manager.Fund.Capital.CostCapital().ToString();
        }

        public void UpdateInfoCore()
        {
            Core core = Core.Instanse;
            labelCountCurMonth.Text = "Текущий ход " + core.GetCurMonth.ToString();
            labelCurSeason.Text = "Сезон " + core.GetCurSeason.ToString();
            labelCountMaxMonth.Text = "Количество ходов " + core.GetSettings.CountStaps.ToString();
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            Visible = false;

            manager.FinishMonth(map.listNewBuilding);

            NextMonth?.Invoke();
        }

        public uint GetCostCapital()
        {
            return manager.Fund.Capital.CostCapital();
        }

        public string GetName()
        {
            return manager.Name;
        }

        private void FundManagerPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                manager.StartMonth();
                UpdatePlayerInfo();
                UpdateInfoCore();
                map.UpdateMap();
            }
        }

        private void buttonShowFormAdvertisingAgency_Click(object sender, EventArgs e)
        {
            FormAdvertisingAgency form = new FormAdvertisingAgency(manager.Fund);
            form.Updater = UpdatePlayerInfo;
            form.Show();
        }
    }
}
