using System;
using System.Collections.Generic;
using System.IO;
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

            List<string> dvadsatdevat = new List<string>();
            dvadsatdevat.Add("Február");
            dvadsatdevat.Add("Februar");
            dvadsatdevat.Add("február");
            dvadsatdevat.Add("februar");

            List<string> tridstat = new List<string>();
            tridstat.Add("Apríl");
            tridstat.Add("April");
            tridstat.Add("apríl");
            tridstat.Add("april");
            tridstat.Add("Jún");
            tridstat.Add("Jun");
            tridstat.Add("jún");
            tridstat.Add("jun");
            tridstat.Add("September");
            tridstat.Add("september");
            tridstat.Add("November");
            tridstat.Add("november");

            List<string> tridstat_jedna = new List<string>();
            tridstat_jedna.Add("január");
            tridstat_jedna.Add("januar");
            tridstat_jedna.Add("Január");
            tridstat_jedna.Add("Januar");
            tridstat_jedna.Add("Marec");
            tridstat_jedna.Add("marec");
            tridstat_jedna.Add("Máj");
            tridstat_jedna.Add("Maj");
            tridstat_jedna.Add("máj");
            tridstat_jedna.Add("maj");
            tridstat_jedna.Add("Júl");
            tridstat_jedna.Add("Jul");
            tridstat_jedna.Add("júl");
            tridstat_jedna.Add("jul");
            tridstat_jedna.Add("August");
            tridstat_jedna.Add("august");
            tridstat_jedna.Add("Október");
            tridstat_jedna.Add("Oktober");
            tridstat_jedna.Add("október");
            tridstat_jedna.Add("oktober");
            tridstat_jedna.Add("December");
            tridstat_jedna.Add("december");

            string mesiac = null;
            int dvadsatdevat_s = 0;
            int tridstat_s = 0;
            int tridstat_jedna_s = 0;

            string den_s = null;
            int den_i = 0;

            string teplota_s = null;
            double teplota_d = 0;

            int pocet_opakovani = 0;

            do
            {
                Console.WriteLine("Zadaj mesiac");
                mesiac = Console.ReadLine();
                if (dvadsatdevat.Contains(mesiac))
                {
                    dvadsatdevat_s = 1;
                    break;
                }
                else if (tridstat.Contains(mesiac))
                {
                    tridstat_s = 1;
                    break;
                }
                else if (tridstat_jedna.Contains(mesiac))
                {
                    tridstat_jedna_s = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("\n!!!Error!!!\n> Zadal si zlý mesiac <\n");
                }
            }
            while (true);

            do
            {
                Console.WriteLine("\nZadaj deň v mesiaci: ");
                den_s = Console.ReadLine();
                den_i = int.Parse(den_s);
                if (den_i < 31)
                {
                    if (dvadsatdevat_s == 1)
                    {
                        if (den_i > 29)
                        {
                            Console.WriteLine("\n!!!Error1!!!");
                        }
                        else
                        {
                            pocet_opakovani = 29 - den_i;
                            break;
                        }
                    }
                    else if (tridstat_s == 1)
                    {
                        if (den_i > 30)
                        {
                            Console.WriteLine("\n!!!Error2!!!");
                        }
                        else
                        {
                            pocet_opakovani = 30 - den_i;
                            break;
                        }
                    }
                    else if (tridstat_jedna_s == 1)
                    {
                        if (den_i > 31)
                        {
                            Console.WriteLine("\n!!!Error3!!!");
                        }
                        else
                        {
                            pocet_opakovani = 31 - den_i;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n!!!Error!!!\n> Zlý dátum <");
                    }
                }
                else
                {
                    Console.WriteLine("\n!!!Error!!!\n> Zlý dátum <");
                }
            }
            while (true);
                Console.WriteLine("Zadaj teplotu: ");
                teplota_s = Console.ReadLine();
                teplota_d = double.Parse(teplota_s);

                Console.WriteLine(den_i + ". " + mesiac + " a teplota je " + teplota_d + "°C");

                for (int i = 0; i < pocet_opakovani; i++)
                {
                    double teplota = int.Parse(teplota_s);
                    double r_n = random_nubmer.NextDouble();
                    teplota = teplota + r_n;
                    teplota = (double)Math.Round(teplota, 1);
                    Console.WriteLine(teplota);
                }
           
        }
    }
}
