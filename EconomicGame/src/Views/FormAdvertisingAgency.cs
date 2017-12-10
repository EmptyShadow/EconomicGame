using EconomicGame.src.Companies;
using EconomicGame.src.Economic.Buildings;
using EconomicGame.src.Funds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomicGame.src.Views
{
    public partial class FormAdvertisingAgency : Form
    {
        /// <summary>
        /// Строительный фонд
        /// </summary>
        public BuildingFund Fund { get; set; }

        public delegate void UpdaterFund();

        public UpdaterFund Updater;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="fund"></param>
        public FormAdvertisingAgency(BuildingFund fund)
        {
            InitializeComponent();
            labelCostAdvertisingAgencyMarket.Text = "Стоимость рекламы магазина = " + AdvertisingAgency.COST_PERCENTAGE_OF_INCREASE_IN_MARKET.ToString();
            labelCostAdvertisingAgencyCondo.Text = "Стоимость рекламы жилья = " + AdvertisingAgency.COST_PERCENTAGE_OF_SALES_OF_CONDO.ToString();

            comboBoxListMarkets.DataSource = fund.Capital.GetMarkets().Keys.ToList<string>();

            Fund = fund;
        }

        /// <summary>
        /// Обработка команды рекламы жилья
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdvertisingCondo_Click(object sender, EventArgs e)
        {
            try
            {
                AdvertisingAgency.AdvertisingHouse(Fund, UInt32.Parse(textBoxAdvertisingСosts.Text));
                Updater?.Invoke();
            } catch (Exception exc)
            {

            }
        }

        
        /// <summary>
        /// Валидация затрат на рекламу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAdvertisingСosts_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox != null)
            {
                try
                {
                    uint value = UInt32.Parse(textbox.Text);
                    Updater?.Invoke();
                } catch (Exception exc)
                {
                    textbox.Text = "0";
                }
            }
        }

        private void buttonAdvertisingMarket_Click(object sender, EventArgs e)
        {
            try
            {
                string addressMarket = comboBoxListMarkets.SelectedItem as string;
                AdvertisingAgency.AdvertisingMarket(Fund, 
                    new KeyValuePair<string, Building>(
                        addressMarket, 
                        Fund.Capital.Things.Building[addressMarket]), 
                    UInt32.Parse(textBoxAdvertisingСosts.Text));
                Updater?.Invoke();
            } catch (Exception exc)
            {

            }
        }
    }
}
