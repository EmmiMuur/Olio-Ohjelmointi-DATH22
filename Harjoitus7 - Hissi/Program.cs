using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7___Hissi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hissi hissi = new Hissi(1, 5, 9);
            hissi.VaihdaKerrosta(4);
            hissi.VaihdaKerrosta(70);
            hissi.VaihdaKerrosta(15);
            hissi.VaihdaKerrosta(8);
            hissi.VaihdaKerrosta(10);
            hissi.VaihdaKerrosta(9);
  


            
        }
    }
}
