using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7___Hissi
{
    internal class Hissi
    {
        public int nykyinenkerros;
        public int minkerros;
        public int maxkerros;

        public Hissi(int nykyinenkerros, int minkerros, int maxkerros)
        {
            this.nykyinenkerros = nykyinenkerros;
            this.minkerros = minkerros;
            this.maxkerros = maxkerros;
        }

        public void VaihdaKerrosta(int uusikerros)
        {
            nykyinenkerros = uusikerros;
            if(nykyinenkerros > maxkerros)
            {
                nykyinenkerros = maxkerros;
            }
            if(nykyinenkerros < minkerros)
            {
                nykyinenkerros = minkerros;
            }
            Console.WriteLine(" hissi on kerroksessa " + nykyinenkerros);

        }

    }
}
