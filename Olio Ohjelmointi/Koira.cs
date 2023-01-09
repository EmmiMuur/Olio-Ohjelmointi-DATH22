using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Ohjelmointi
{
    internal class Koira
    {
        public string Nimi;
        public string Rotu;
        public int Ikä;

        // Konstruktori jolla pakotetaan olion luonti tilanteessa
        // antamana tarvittavat tiedot oliolle (esim nimi, rotu ja ikä)

        public Koira(string nimi, string rotu, int ikä)
        {
            Nimi = nimi;
            Rotu = rotu;
            Ikä = ikä;
        }


        public void HaeTiedot()
        {
            Console.WriteLine("Koiran nimi on" + Nimi);
            Console.WriteLine("Koiran ikä on" + Ikä);
            Console.WriteLine("Koiran rotu on" + Rotu);
        }

        public void Hauku()
        {
            Console.WriteLine(Nimi + " woof woof ");
        }
    }
}
