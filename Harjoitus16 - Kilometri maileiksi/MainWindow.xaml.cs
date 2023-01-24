using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus16___Kilometri_maileiksi
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

        private void input_arvo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // TextBox kentän tarkistus että voidaan kirjoittaa vain numeroita 6-9 väliltä
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btn_muunnakm_Click(object sender, RoutedEventArgs e)
        {
            int arvo = int.Parse(input_arvo.Text);
            txt_lopputulos.Text = " Kilometreinä on " + KmToMiles(arvo);
        }

        private void bdn_muunnamaileiksi_Click(object sender, RoutedEventArgs e)
        {
            int arvo = int.Parse(input_arvo.Text);
            txt_lopputulos.Text = " Metreinä on " + MilesToKm(arvo);
        }

        public static float KmToMiles(float km)
        {
            float conversionRate = 0.62137f;
            return km * conversionRate;
        }

        public static float MilesToKm(float km)
        {
            float conversionRate = 1.62137f;
            return km * conversionRate;
        }
    }
}
