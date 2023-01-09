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
            Koira koira1= new Koira("Rekku", "Mopsi", 2 ); // Luodaan uusi koira olio/instanssi
           
            koira1.HaeTiedot();

            Koira koira2 = new Koira("Ali", "Bulldog",5 );
          
            koira2.HaeTiedot();

            koira1.Hauku();
            koira2.Hauku();
        }
    }
}
