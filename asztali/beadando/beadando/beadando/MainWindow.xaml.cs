using System.Configuration;
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

namespace beadando
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i <= 90; i++) 
            {
                textblock.Text += i+", ";
            }

            for (int j = 0; j < 46; j++)
            {
                textblock1.Text += j + ", ";
            }

            for (int i = 0; i <= 35; i++)
            {
                textblock2.Text += i + ", ";
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox1.IsChecked == true) 
            {
                Window1 window1 = new Window1();
                window1.Show();
                szamaid.Text=((Window)Application.Current).Text;
            }

            if (checkbox2.IsChecked == true)
            {
                Window2 window2 = new Window2();
                window2.Show();
                szamaid.Text = ((Window)Application.Current).Text;
            }

            if (checkbox3.IsChecked == true)
            {
                Window3 window3 = new Window3();
                window3.Show();
                szamaid.Text = ((Window)Application.Current).Text;
            }
        }
    }
}