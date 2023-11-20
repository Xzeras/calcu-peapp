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
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static int MoinMethodInt(int x, int y)
        {
            return x - y;
        }

        static int DivisionsMethodInt(int x, int y)
        {
            return x / y;
        }

        static int MultiMethodInt(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue Sur La Calculatrice");                    // phrase du debut
            bool t = true;
            string s;                                                              // prouver que (s) est un string

            do
            {                                                                      
            int y = Convert.ToInt32(Console.ReadLine());                           // (y) lit les premiers nombres
            string x = Console.ReadLine();                                         // (x) lit les (+ - * /) qui ont été écris
            int e = Convert.ToInt32(Console.ReadLine());                           // (e) lit les deuxiemes nombres




                if (x == "+")                                                      // si (x) lit (+) il s'active
                {

                    int w = PlusMethodInt(y, e);
                    Console.WriteLine();
                    Console.WriteLine(w);
                    Console.WriteLine("Voulez vous fair un autre calcul ?");
                    Console.WriteLine("oui/ non");
                }

                else if (x == "-")                                                 // si (x) lit (-) il s'active
                {
                    int w = MoinMethodInt(y, e);
                    Console.WriteLine();
                    Console.WriteLine(w);
                    Console.WriteLine("Voulez vous fair un autre calcul ?");
                    Console.WriteLine("oui/ non");
                }

                else if (x == "/")                                                 // si (x) lit (/) il s'active
                {
                    int w = DivisionsMethodInt(y, e);
                    Console.WriteLine();
                    Console.WriteLine(w);
                    Console.WriteLine("Voulez vous fair un autre calcul ?");
                    Console.WriteLine("oui/ non");
                }

                else if (x == "*")                                                 // si (x) lit (*) il s'active
                {
                    int w = MultiMethodInt(y, e);
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
 
            } 
            while (t);

            








        }
    }
}
