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
            string den = Console.ReadLine();

            Console.WriteLine("Zadaj mesiac");
            string mesiac = Console.ReadLine();

            Console.WriteLine("Zadal si: " + den.ToString() + ". " + mesiac);


        }
    }
}
