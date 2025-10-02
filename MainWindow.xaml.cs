using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> drinks = new Dictionary<string, int>()
        {
            {"紅茶大杯",60 },
            {"紅茶中杯",45 },
            {"綠茶大杯", 55},
            {"綠茶中杯",45 },
            { "烏龍茶大杯",75},
            { "烏龍茶中杯",70}
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            var rb = sender as RadioButton;
            
        }
    }
}