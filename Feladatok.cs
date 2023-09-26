using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Feladatok
    {
        private List<Bejegyzes> lista = new List<Bejegyzes>();
        private List<Bejegyzes> lista2 = new List<Bejegyzes>();
        public void ListaEgy()
        {
            int darabszam;
            string szerzo;
            string tartalom;
            Console.WriteLine("Kérem írjon be egy darabszámot!");
            darabszam = Convert.ToInt32(Console.ReadLine());
            if (darabszam < 0)
            {
                Console.WriteLine("Ez nem egy természetes szám!");
            }
            else
            {
                for (int i = 0; i < darabszam; i++)
                {
                    Console.WriteLine("Kérem adja meg a szerzőt!");
                    szerzo = Console.ReadLine();
                    Console.WriteLine("Kérem adja meg a tartalmat!");
                    tartalom = Console.ReadLine();
                    Bejegyzes bejegyzesx = new Bejegyzes(szerzo, tartalom);
                    lista.Add(bejegyzesx);
                }
            }
        }
    }
}
