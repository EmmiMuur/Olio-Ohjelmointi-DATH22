using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus5___Laskin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Laskin.summa(13, 6));
            Console.WriteLine(Laskin.erotus(4, 2));
            Console.WriteLine(Laskin.kertolasku(7, 6));
            Console.WriteLine(Laskin.jakolasku(10, 5));


        }
    }
}
