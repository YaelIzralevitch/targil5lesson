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

namespace WpfApp1
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

        private void redLight_Click(object sender, RoutedEventArgs e)
        {
            if (errorImage.IsVisible)
            {
                errorImage.Visibility = Visibility.Hidden;
            }
            MessageBox.Show("BREAKS");
        }

        public int i = 0;

        private void greenLight_Click(object sender, RoutedEventArgs e)
        {
            i = i + 12;
            pinkCar.Margin = new Thickness(603 - i, 252, 0, 0);
        }

        private void yellowLight_Click(object sender, RoutedEventArgs e)
        {
            i = i + 5;
            pinkCar.Margin = new Thickness(603 - i, 252, 0, 0);
            errorImage.Visibility = Visibility.Visible;   
        }
    }
}