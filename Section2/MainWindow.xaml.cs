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

namespace Section2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lbResult.Content = "ERROR";
        }

        private void btAC_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Content = "0";
        }

        private void btOne_Click(object sender, RoutedEventArgs e)
        {
            if ((lbResult.Content.ToString() == "ERROR") || (lbResult.Content.ToString() == "0"))
            {
                lbResult.Content = "1";
            }
            else
            {
                lbResult.Content = $"{lbResult.Content}1";
            }
        }
    }
}
