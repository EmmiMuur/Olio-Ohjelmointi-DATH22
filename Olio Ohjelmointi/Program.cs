using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_Ohjelmointi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koira koira1= new Koira(); // Luodaan uusi koira olio/instanssi
            koira1.Nimi = " Rekku ";
            koira1.Ikä = 2;
            koira1.Rotu = " Mopsi ";

            koira1.HaeTiedot();

            Koira koira2 = new Koira();
            koira2.Nimi = " Ali ";
            koira2.Ikä = 5;
            koira2.Rotu = " Bulldog ";

            koira2.HaeTiedot();

            koira1.Hauku();
            koira2.Hauku();
        }
    }
}
