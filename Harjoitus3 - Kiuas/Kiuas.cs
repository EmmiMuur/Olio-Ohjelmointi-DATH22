using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3___Kiuas
{
    internal class Kiuas
    {
        public bool Onkopäällä;
        public int Lämpötila;
        public int Kosteus;

        public void KiuasPäälle()
        {
            Onkopäällä= true;
            Console.WriteLine("Kiuas on päällä");
        }
        
        public void KiuasPois()
        {
            Onkopäällä= false;
            Console.WriteLine("Kiuas ei ole päällä");
        }

        public void MuutaLämpötilaa(int uusilämpötila)
        {
            if (Onkopäällä)
            {
                Lämpötila = uusilämpötila;
                Console.WriteLine("Saunan lämpötila on " + Lämpötila);
            }

        }
            public void MuutaKosteutta(int uusikosteus)
            {
                if (Onkopäällä)
                {
                    Kosteus = uusikosteus;
                    Console.WriteLine("Saunan kosteus on " + Kosteus);
                }




            }

    }
}
