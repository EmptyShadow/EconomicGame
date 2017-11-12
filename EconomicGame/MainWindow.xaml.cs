using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EconomicGame.src;
using EconomicGame.src.Economic;
using EconomicGame.src.Economic.Buildings;

namespace EconomicGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Havings markets = new Havings();
            Market market1 = new Market("Example market 1", 1, 100000, 50000, 5);
            Market market2 = new Market("Example market 2", 3, 1000000, 500000, 40);
            markets.Add(market1);
            markets.Add(market2);
            ResourсesLoaderXML.SaveHavingsMarket(markets);
        }
    }
}
