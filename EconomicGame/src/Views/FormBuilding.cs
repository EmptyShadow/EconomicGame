using EconomicGame.src.Economic.Buildings;
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
    public partial class FormBuilding : Form
    {
        public delegate void SendBuilding(Building building);

        public SendBuilding HandlerSendBuiling;

        List<string> listTypeBuilding = new List<string>();

        Core core = Core.Instanse;

        public FormBuilding()
        {
            InitializeComponent();

            listTypeBuilding.Add("Жилые Дома");
            listTypeBuilding.Add("Магазины");

            comboBoxTypeBuilding.DataSource = listTypeBuilding;
        }

        private void comboBoxTypeBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null) { return; }

            switch (comboBox.SelectedItem.ToString())
            {
                case "Жилые Дома":
                    comboBoxListBuilding.DataSource = core.GetListHouses;
                    comboBoxListBuilding.DisplayMember = "Name";
                    break;
                case "Магазины":
                    comboBoxListBuilding.DataSource = core.GetListMarkets;
                    comboBoxListBuilding.DisplayMember = "Name";
                    break;
            }
        }

        private void comboBoxListBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null) { return; }

            Building building = comboBox.SelectedItem as Building;
            if (building == null) { return; }

            labelBuilding.Text = building.ShortInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Building building = comboBoxListBuilding.SelectedItem as Building;
            if (building == null) { return; }
            Close();
            HandlerSendBuiling?.Invoke((Building)building.Clone());
        }
    }
}
