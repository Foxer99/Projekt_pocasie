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

            Random random_nubmer = new Random();


         
            List<string> tridstat_jedna = new List<string>();
            string februar = "29";

            Console.WriteLine("Zadaj deň v mesiaci: ");
            string den_s = Console.ReadLine();
            int den_i = int.Parse(den_s);

            Console.WriteLine("Zadaj mesiac");
            string mesiac = Console.ReadLine();

            Console.WriteLine("Zadaj teplotu: ");
            string teplota_s = Console.ReadLine();
            double teplota_d = double.Parse(teplota_s);

            Console.WriteLine(den_i + ". " + mesiac + " a teplota je " + teplota_d + "°C");

            for (int i = 0; i < 100; i++)
            {
                double teplota = int.Parse(teplota_s);
                double r_n = random_nubmer.NextDouble();
                teplota = teplota + r_n;
                teplota = (double)Math.Round(teplota,1);
                Console.WriteLine(teplota);

            }
        }
    }
}
