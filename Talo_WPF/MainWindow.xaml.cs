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

namespace Talo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double lämpötila = 20;
        bool keittiöValot = false;
        bool olohuoneenValot = false;
        bool oviLukossa = false ;

        public MainWindow()
        {
            InitializeComponent();
            txt_lämpötila.Text = "Lämpötila: " + lämpötila;
            txt_keittiönvalot.Text = " Keittiön valot on pois päältä";
            txt_ovilukkoon.Text = " Ovi on auki ";
            txt_olohuoneenvalot.Text = " Olohuoneen valot on päällä";

        }


        private void btn_keittiövalot_Click(object sender, RoutedEventArgs e)
        {
            keittiöValot = !keittiöValot;

            if(keittiöValot)
            {
                txt_keittiönvalot.Text = " Keittiön valot on päällä";

            }
            else
            {
                txt_keittiönvalot.Text = " Keittiön valot on pois päältä";
            }


        }

        private void slider_lämpötila_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lämpötila = slider_lämpötila.Value;
            txt_lämpötila.Text = "Lämpötila: " + lämpötila;
        }

        private void btn_OlohuoneenValot_Click(object sender, RoutedEventArgs e)
        {
            olohuoneenValot = !olohuoneenValot;

            if (olohuoneenValot)
            {
                txt_olohuoneenvalot.Text = " Olohuoneen valot on päällä";

            }
            else
            {
                txt_olohuoneenvalot.Text = " Olohuoneen valot on pois päältä";
            }


        }

        private void btn_OviLukkoon_Click(object sender, RoutedEventArgs e)
        {
            oviLukossa  = !oviLukossa;

            if (oviLukossa)
            {
                txt_ovilukkoon.Text = " Ovi on lukossa";
            }
            else
            {
                txt_ovilukkoon.Text = " Ovi on auki ";
            }


        }
    }

}
