using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2___Opiskelija
{
    internal class Opiskelija
    {

        public string Nimi;
        public string OpiskelijaID;
        public int Opintopisteet;

        public Opiskelija(string nimi, string opsikelijaID, int opintopisteet)
        {
            Nimi = nimi;
            OpiskelijaID = opsikelijaID;
            Opintopisteet = opintopisteet;
        }

        public void TulostaData()
        {
            Console.WriteLine(" Opiskelijan nimi on  " + Nimi);
            Console.WriteLine(" Opiskelijan opiskelijaID on " + OpiskelijaID);
            Console.WriteLine(" Opiskelijan opiskelupisteet on " + Opintopisteet);
        }
        public void Muokkaaopintopisteitä(int määrä)
        {
            Opintopisteet += määrä;
        }

    }
}
