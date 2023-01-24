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

namespace Harjoitus15___Autolaskuri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int Kuormaauto;
        int Auto;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bdn_ekanappi_Click(object sender, RoutedEventArgs e)
        {
            Auto++;
            txt_ekateksti.Text= " Autoja  on " + Auto;

        }

        private void bdn_tokanappi_Click(object sender, RoutedEventArgs e)
        {
            Kuormaauto++;
            txt_tokateksti.Text= " Kuormaautoja on " + Kuormaauto;
            
        }
    }
}
