using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bohaterowi łucznik = new Bohaterowi();
            łucznik.imie = "Goblin";
            łucznik.Zywotnosc = 100;
            łucznik.zręczność = 15;
            łucznik.PT = 3;
            Console.WriteLine("Łucznik");
            Console.WriteLine();
            łucznik.Łucznik();
            Bohaterowi wojownik = new Bohaterowi();
            wojownik.imie = "OrkA";
            wojownik.Zywotnosc = 19;
            wojownik.siła = 15;
            wojownik.PT = 1;
            Console.WriteLine("Wojownik");
            Console.WriteLine();
            wojownik.Wojownik();
            
            
            Console.ReadKey();
            
        }
    }
}
