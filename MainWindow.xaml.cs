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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var targetTextBox = sender as TextBox;
            var targetStaclkPanel = targetTextBox.Parent as StackPanel;
            var targetNameLabel = targetStaclkPanel.Children[0] as Label;
            var targetPricelLabel = targetStaclkPanel.Children[1] as Label;
            int amout;
            bool success = int.TryParse(targetTextBox.Text, out amout);

            if (!success) MessageBox.Show("請輸入正確的數值", "輸入錯誤");
            else
            {
                string drinkname = targetNameLabel.Content.ToString();
                int price = Convert.ToInt32(targetPricelLabel.Content.ToString().Substring(0, 2));
                MessageBox.Show($"你選擇的飲料是{drinkname},單價是{price}元, 總價{price * amout}元", "訂購成功");
                MessageBox.Show($"你輸入的數值是{amout}", "輸入成功");
            }
        }

    }
}