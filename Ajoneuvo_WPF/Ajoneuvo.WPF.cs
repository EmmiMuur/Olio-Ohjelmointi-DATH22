using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajoneuvo_WPF
{
    internal class Ajoneuvo
    {
        public string Model { get; set; }
        public string Speed { get; set; }
        public string Tyres { get; set; }

        public string HaeTiedot()
        {
            return Model + "Ajoneuvolla on " + Tyres + " Rengasta ja maksiminopeus on " + Speed;
        }
         
    }
}
