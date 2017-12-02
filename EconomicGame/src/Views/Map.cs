using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EconomicGame.src.Economic;
using EconomicGame.src.Economic.Buildings;
using EconomicGame.src.Utils;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace EconomicGame.src.Views
{
    public partial class Map : UserControl
    {
        private Havings buildings;
        public Dictionary<System.Windows.Point, Building> listNewBuilding = new Dictionary<System.Windows.Point, Building>();

        public Map()
        {
            InitializeComponent();
            tableMapBuildings.ColumnCount = 3;
            tableMapBuildings.RowCount = 3;

            for (int i = 0; i < tableMapBuildings.ColumnCount; i++)
            {
                for (int j = 0; j < tableMapBuildings.RowCount; j++)
                {
                    AddControl(new BuildingControl(i, j), i, j);
                }
            }
        }

        private void AddControl(BuildingControl buildingControl, int col, int row)
        {
            buildingControl.Visible = true;
            buildingControl.Dock = DockStyle.Fill;
            tableMapBuildings.Controls.Add(buildingControl, col, row);
            buildingControl.AutoScroll = true;
            buildingControl.ChangedBuilding = HandlerChangedBuilding;
        }

        private void UpdateBuildingControl(Building building, int col, int row)
        {
            BuildingControl buildingControl = tableMapBuildings.GetControlFromPosition(col, row) as BuildingControl;
            if (buildingControl != null)
            {
                buildingControl.Building = building;
                buildingControl.Update();
            }
        }

        public void HandlerChangedBuilding(object sender)
        {
            BuildingControl control = sender as BuildingControl;
            if (control != null && control.Building != null)
            {
                listNewBuilding.Add(new System.Windows.Point(control.X, control.Y), control.Building);
            }
        }

        /// <summary>
        /// Обновление карты
        /// </summary>
        public void UpdateMap()
        {
            listNewBuilding = new Dictionary<System.Windows.Point, Building>();
            // Если список зданий не пуст
            if (buildings != null)
            {
                // Убираем все из таблицы
                //tableMapBuildings.Controls.Clear();
                // проходим по всем зданиям
                foreach(KeyValuePair<string, Building> building in buildings.Building)
                {
                    System.Windows.Point address = ClassString.StringToPoint(building.Key);
                    UpdateBuildingControl(building.Value, (int)address.X, (int)address.Y);
                }
                tableMapBuildings.Refresh();
            }
        }

        public Havings Buildings
        {
            set
            {
                if (value != null)
                {
                    buildings = value;
                    UpdateMap();
                }
            }
        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableMapBuildings.RowCount = ++tableMapBuildings.RowCount;
            for (int i = 0; i < tableMapBuildings.ColumnCount; i++)
            {
                AddControl(new BuildingControl(i, tableMapBuildings.RowCount - 1), i, tableMapBuildings.RowCount - 1);
            }
        }

        private void добавитьСтолбецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableMapBuildings.ColumnCount = ++tableMapBuildings.ColumnCount;
            for (int i = 0; i < tableMapBuildings.RowCount; i++)
            {
                AddControl(new BuildingControl(tableMapBuildings.ColumnCount - 1, i), tableMapBuildings.ColumnCount - 1, i);
            }
        }
    }
}
