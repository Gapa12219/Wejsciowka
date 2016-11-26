using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wejsciowka4
{
    class Bohaterowi
    {
        public string imie { get; set; }
        public int Zywotnosc { get; set; }
        public int PT {get; set;}
        public int siła {get; set;}
        public int zręczność {get; set;}

        public int mocAtakuŁucznik;
        public int mocAtakuWojownik;
       public void Łucznik(){
           mocAtakuŁucznik = zręczność * PT * Zywotnosc;
           Console.WriteLine("imie {0}\nżywotność {1}%\nzręczność {2}\nPT {3}\nmoc ataku {4}\n", imie,Zywotnosc,zręczność,PT,mocAtakuŁucznik);
           if (Zywotnosc > 0 && Zywotnosc < 100)
           {
               Console.WriteLine("Zmiana pkt zycia");
               Zywotnosc = int.Parse(Console.ReadLine());
                mocAtakuŁucznik = zręczność * PT * Zywotnosc;
                Console.WriteLine("imie {0}\nżywotność {1}%\nzręczność {2}\nPT {3}\nmoc ataku {4}\n", imie, Zywotnosc, zręczność, PT, mocAtakuŁucznik);
           }
           else
           {
               Console.WriteLine("Nie mozesz zmienic pkt zycia \n");
           }
       }
        public void Wojownik(){
            mocAtakuWojownik = siła * PT * Zywotnosc;
            Console.WriteLine("imie {0}\nżywotność {1}%\nsiła {2}\nPT {3}\nmoc ataku {4}\n",imie,Zywotnosc,siła,PT,mocAtakuWojownik);


            if (Zywotnosc > 20 && Zywotnosc < 100)
            {
                Console.WriteLine("Zmiana pkt zycia");
                Zywotnosc = int.Parse(Console.ReadLine());
                mocAtakuWojownik = siła * PT * Zywotnosc;
                Console.WriteLine("imie {0}\nżywotność {1}%\nsiła {2}\nPT {3}\nmoc ataku {4}\n", imie, Zywotnosc, siła, PT, mocAtakuWojownik);

            }
            else if ( Zywotnosc < 20)
            {
                
                
                    Zywotnosc = 150;
                    mocAtakuWojownik = siła * PT * Zywotnosc;
                    Console.WriteLine("Wojownik wpadł w szał");
                    Console.WriteLine("imie {0}\nżywotność {1}%\nsiła {2}\nPT {3}\nmoc ataku {4}\n", imie, Zywotnosc, siła, PT, mocAtakuWojownik);

                
            }
            else
            {
                Console.WriteLine("Nie mozesz zmienic pkt zycia");
            }
            
        }
        public void ZmianaPktŻycia()
        {
            
        }
       
      
    }
}
