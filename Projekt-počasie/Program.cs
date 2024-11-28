using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_počasie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj deň: ");
            string den_s = Console.ReadLine();
            int den_i = int.Parse(den_s);

            Console.WriteLine("Zadaj mesiac");
            string mesiac = Console.ReadLine();

            Console.WriteLine("Zadaj teplotu: ");
            string teplota_s = Console.ReadLine();
            double teplota_d = double.Parse(teplota_s);

            Console.WriteLine("Zadal si " + den_i + ". " + mesiac + " a teplota je " + teplota_d + "°C");


        }
    }
}
