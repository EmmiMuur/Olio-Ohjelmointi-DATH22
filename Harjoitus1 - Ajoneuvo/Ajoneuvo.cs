using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1___Ajoneuvo
{
    internal class Ajoneuvo
    {
        public string Merkki;
        public int Nopeus;
        public int Renkaat;

        public Ajoneuvo(string merkki, int nopeus, int renkaat)
        {
            Merkki = merkki;
            Nopeus = nopeus;
            Renkaat = renkaat;
        }

        public void TulostaData()
        {
            Console.WriteLine(" Auton merkki on " + Merkki);
            Console.WriteLine(" Auton nopeus on " + Nopeus);
            Console.WriteLine(" Auton renkaat on " + Renkaat);
        }

    }
}
