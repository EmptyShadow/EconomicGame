using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EconomicGame.src.Economic.Buildings;
using EconomicGame.src.Utils;

namespace EconomicGame.src.Views
{
    public partial class BuildingControl : UserControl
    {
        public delegate void Changed(object controlSender);
        public Changed ChangedBuilding;

        public Building Building { get; set; }
        public int X { get; set; } = -1;
        public int Y { get; set; } = -1;
        ToolTip toolTip = new ToolTip();
        
        const string IMG_HOUSE = "\\Resourсes\\Images\\house.png";
        const string IMG_MARKET = "\\Resourсes\\Images\\market.png";
        const string IMG_HOUSE_FROST = "\\Resourсes\\Images\\frost_house.png";
        const string IMG_MARKET_FROST = "\\Resourсes\\Images\\frost_market.png";
        const string IMG_HOUSE_NOT_SALE = "\\Resourсes\\Images\\not_sale_house.png";
        const string IMG_HOUSE_NOT_SALE_FROST = "\\Resourсes\\Images\\not_sale_frost_house.png";

        public BuildingControl()
        {
            InitializeComponent();

            flowLayoutPanelUpgradeBuilding.Visible = false;
            textBoxCostSquareMeter.Visible = false;
        }

        public BuildingControl(int x, int y, Building building = null)
        {
            InitializeComponent();
            toolTip.UseAnimation = true;
            toolTip.UseFading = true;
            toolTip.AutoPopDelay = 20000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 100;

            X = x;
            Y = y;
            Building = building;
            Update();
        }

        public void Update()
        {
            flowLayoutPanelUpgradeBuilding.Visible = false;
            textBoxCostSquareMeter.Visible = false;

            if (Building != null)
            {
                string path = Environment.CurrentDirectory;
                // флаг заморозки строительства, флаг не продажи квартир, флаг построено ли здание
                bool flagFrost = false, flagNotSale = false, flagBuild = false;

                // проверяем заморозку и постройку
                flagFrost = Building.IsFreeze;
                flagBuild = Building.IsBuild();

                House house = Building as House;
                Market market = Building as Market;

                Bitmap imageBuilding = null;

                // Если жилое здание
                if (house != null)
                {
                    textBoxCostSquareMeter.Visible = true;

                    if (house.GetCountNotSoldCondos() == 0)
                    {
                        flagNotSale = true;
                    }

                    if (flagFrost && flagNotSale)
                    {
                        path += IMG_HOUSE_NOT_SALE_FROST;
                        imageBuilding = new Bitmap(path);
                    }
                    else if (flagFrost)
                    {
                        path += IMG_HOUSE_FROST;
                        imageBuilding = new Bitmap(path);
                    }
                    else if (flagNotSale)
                    {
                        path += IMG_HOUSE_NOT_SALE;
                        imageBuilding = new Bitmap(path);
                    }
                    else
                    {
                        path += IMG_HOUSE;
                        imageBuilding = new Bitmap(path);
                    }

                }
                else if (market != null)
                {
                    if (flagFrost)
                    {
                        path += IMG_MARKET_FROST;
                        imageBuilding = new Bitmap(path);
                    }
                    else
                    {
                        path += IMG_MARKET;
                        imageBuilding = new Bitmap(path);
                    }
                }

                // Если изображение здания открыто и оно не построенно
                if (!flagBuild && imageBuilding != null)
                {
                    // Обесцвечиваем
                    GrayScale(ref imageBuilding);
                }

                labelBuilding.Image = imageBuilding;

                toolTip.SetToolTip(labelBuilding, Building.ToString());
            }
        }

        public void GrayScale(ref Bitmap bmp)
        {
            //get image dimension
            int width = bmp.Width;
            int height = bmp.Height;

            //color of pixel
            System.Drawing.Color p;

            //grayscale
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    p = bmp.GetPixel(x, y);

                    //extract pixel component ARGB
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //find average
                    int avg = (r + g + b) / 3;

                    //set new pixel value
                    bmp.SetPixel(x, y, System.Drawing.Color.FromArgb(a, avg, avg, avg));
                }
            }
        }

        private void labelBuilding_Click(object sender, EventArgs e)
        {
            if (Building != null)
            {
                flowLayoutPanelUpgradeBuilding.Visible = !flowLayoutPanelUpgradeBuilding.Visible;
            } else
            {
                FormBuilding form = new FormBuilding();
                form.HandlerSendBuiling = HandlerSendBuildingForm;
                form.Show();
            }
        }

        private void HandlerSendBuildingForm(Building building)
        {
            if (building != null)
            {
                Building = building;
                Update();
                ChangedBuilding?.Invoke(this);
            }
        }

        private void textBoxCostSquareMeter_TextChanged(object sender, EventArgs e)
        {
            TextBox val = sender as TextBox;
            try
            {
                if (val != null)
                {
                    uint valCost = UInt32.Parse(val.Text);
                    ((House)Building).CostSquareMeter = valCost;
                }
            } catch(Exception exp)
            {
                val.Text = ((House)(Building)).GetPrimeCostPerSquareMeter().ToString();
            }
        }

        private void checkBoxIsFreese_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox isFreeze = sender as CheckBox;
            if (isFreeze != null)
            {
                Building.IsFreeze = isFreeze.Checked;
                Update();
            }
        }
    }
}
