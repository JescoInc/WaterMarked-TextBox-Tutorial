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

namespace WaterMarkedTextBoxTutorial
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

        private void userInput_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userInput.Text))
            {
                userInput.Visibility = System.Windows.Visibility.Collapsed;
                watermarkedTxt.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkedTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            userInput.Visibility = System.Windows.Visibility.Visible;
            watermarkedTxt.Visibility = System.Windows.Visibility.Collapsed;
            userInput.Focus();
        }
    }
}
