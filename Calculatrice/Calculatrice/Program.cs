using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue Sur La Calculatrice"); // phrase du debut

            string s;                                       // prouver que (s) est un string
            int y = Convert.ToInt32(Console.ReadLine());    // (y) lit les premiers nombres
            string x = Console.ReadLine();                  // (x) lit les (+ - * /) qui ont été écris
            int e = Convert.ToInt32(Console.ReadLine());    // (e) lit les deuxiemes nombres
            bool t = true;


            do
            {

                if (x == "+")                                                      // si (x) lit (+) il s'active
                {
                    int w = y + e;
                    Console.WriteLine();
                    Console.WriteLine(w);
                    Console.WriteLine("Voulez vous fair un autre calcul ?");
                    Console.WriteLine("oui/ non");
                }

                else if (x == "-")                                                 // si (x) lit (-) il s'active
                {
                    int w = y - e;
                    Console.WriteLine();
                    Console.WriteLine(w);
                    Console.WriteLine("Voulez vous fair un autre calcul ?");
                    Console.WriteLine("oui/ non");
                }
                else if (x == "/")                                                 // si (x) lit (/) il s'active
                {
                    int w = y / e;
                    Console.WriteLine();
                    Console.WriteLine(w);
                    Console.WriteLine("Voulez vous fair un autre calcul ?");
                    Console.WriteLine("oui/ non");
                }
                else if (x == "*")                                                 // si (x) lit (*) il s'active
                {
                    int w = y * e;
                    Console.WriteLine();
                    Console.WriteLine(w);
                    Console.WriteLine("Voulez vous fair un autre calcul ?");
                    Console.WriteLine("oui/ non");
                }

                 s = Console.ReadLine();                                         
                if ( s == "non")                                                   // si (s) lit (non) il s'active
                {
                    t = false;                                                     // active la fin de la boucle
                }
   
            } while (false);

            Console.ReadKey();

            








        }
    }
}
