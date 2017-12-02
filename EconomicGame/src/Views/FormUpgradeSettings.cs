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
    public partial class FormUpgradeSettings : Form
    {
        Settings DefSettings = ResourсesLoaderXML.LoadSettings(ResourсesLoaderXML.DEF_SETTINGS);

        public FormUpgradeSettings()
        {
            InitializeComponent();
            ViewSetting();
        }

        private void CountTextBoxValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !CountValidate(sender as TextBox);
        }

        private void CoefTextBoxValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !CoefValidate(sender as TextBox);
        }

        private bool CountValidate(TextBox textBox)
        {
            if (textBox != null)
            {
                try
                {
                    int val = Int32.Parse(textBox.Text);

                    if (val <= 0)
                    {
                        throw new Exception("Отрицательное число!!");
                    }
                } catch (Exception e)
                {
                    this.mainFormErrorProvider.SetError(textBox, e.Message);
                    return false;
                }
            }
            this.mainFormErrorProvider.Clear();
            return true;
        }

        private bool CoefValidate(TextBox textBox)
        {
            if (textBox != null)
            {
                try
                {
                    double val = Double.Parse(textBox.Text);

                    if (val <= 0.0)
                    {
                        throw new Exception("Отрицательное число!!");
                    }
                }
                catch (Exception e)
                {
                    this.mainFormErrorProvider.SetError(textBox, e.Message);
                    return false;
                }
            }
            this.mainFormErrorProvider.Clear();
            return true;
        }

        private void ViewSetting()
        {
            countPlayer.Text = DefSettings.CountPlayers.ToString();
            countsStaps.Text = DefSettings.CountStaps.ToString();
            startCapital.Text = DefSettings.StartCapital.ToString();
            costThings.Text = DefSettings.OrdinaryDemandHouse.CostThings.ToString();
            countThings.Text = DefSettings.OrdinaryDemandHouse.CountThings.ToString();
            countSalesSquareMetersInMonth.Text = DefSettings.CountSalesSquareMetersInMonth.ToString();
            levelSalesMarket.Text = DefSettings.LevelSalesMarket.ToString();
            CoefsSeasonsHouse1.Text = DefSettings.CoefsSeasonsHouse[0].ToString();
            CoefsSeasonsHouse2.Text = DefSettings.CoefsSeasonsHouse[1].ToString();
            CoefsSeasonsHouse3.Text = DefSettings.CoefsSeasonsHouse[2].ToString();
            CoefsSeasonsHouse4.Text = DefSettings.CoefsSeasonsHouse[3].ToString();
            CoefsSeasonsMarket1.Text = DefSettings.CoefsSeasonsMarket[0].ToString();
            CoefsSeasonsMarket2.Text = DefSettings.CoefsSeasonsMarket[1].ToString();
            CoefsSeasonsMarket3.Text = DefSettings.CoefsSeasonsMarket[2].ToString();
            CoefsSeasonsMarket4.Text = DefSettings.CoefsSeasonsMarket[3].ToString();
            borderFavorableOutcome.Text = DefSettings.BorderFavorableOutcome.ToString();
        }

        private Settings GetSettingsInForm()
        {
            try
            {
                Settings settings = new Settings(
                    UInt32.Parse(countPlayer.Text),
                    UInt32.Parse(countsStaps.Text),
                    UInt32.Parse(startCapital.Text),
                    new Economic.Demand(
                        UInt32.Parse(costThings.Text),
                        UInt32.Parse(countThings.Text)
                        ),
                    UInt32.Parse(countSalesSquareMetersInMonth.Text),
                    Double.Parse(levelSalesMarket.Text),
                    new double[]
                    {
                    Double.Parse(CoefsSeasonsHouse1.Text),
                    Double.Parse(CoefsSeasonsHouse2.Text),
                    Double.Parse(CoefsSeasonsHouse3.Text),
                    Double.Parse(CoefsSeasonsHouse4.Text)
                    },
                    new double[]
                    {
                    Double.Parse(CoefsSeasonsMarket1.Text),
                    Double.Parse(CoefsSeasonsMarket2.Text),
                    Double.Parse(CoefsSeasonsMarket3.Text),
                    Double.Parse(CoefsSeasonsMarket4.Text)
                    },
                    Double.Parse(borderFavorableOutcome.Text)
                    );

                return settings;
            } catch (Exception e)
            {
                return null;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Settings settingsToSave = GetSettingsInForm();
            if (settingsToSave != null)
            {
                ResourсesLoaderXML.SaveSettings(settingsToSave);
                Close();
            }
        }
    }
}
