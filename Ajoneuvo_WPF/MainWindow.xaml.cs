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

namespace Ajoneuvo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List aolemassa olevista autoista
        List<Ajoneuvo> ajoneuvot = new List<Ajoneuvo>();
        public MainWindow()
        {
            InitializeComponent();
        }

        //kun painetaan nappia niin luodaan uusi Auto olio annetuista tiedoista
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //luodaan uusi ajoneuvo olio
            Ajoneuvo uusiAjoneuvo= new Ajoneuvo();

            //Asetetaan ajoneuvolle käyttäjän syötteen mukaiset tiedot
            uusiAjoneuvo.Model = Malli.Text;
            uusiAjoneuvo.Speed = Maksiminopeus.Text; 
            uusiAjoneuvo.Tyres = Renkaiden_määrä.Text;

            //resetoidaan käyttäjän syöte tyhjäksi TextBoxiksi
            Malli.Text = "";
            Maksiminopeus.Text = "";
            Renkaiden_määrä.Text = "";

            //Lisätään viesti sovellukseen joka kertoo että uusi ajoneuvo on luotu
            txt_LuotuAjoneuvo.Text = "Luotu uusi ajoneuvo tiedoilla:\n" + uusiAjoneuvo.HaeTiedot();
            ajoneuvot.Add(uusiAjoneuvo);//Lisätään uusi ajoneuvo listaan


        }
        

        

      
    }
}
