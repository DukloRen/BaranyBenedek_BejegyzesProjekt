using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public void Feltoltes()
        {
            StreamReader olvaso = new StreamReader("bejegyzesek.csv");
            while (!olvaso.EndOfStream)
            {
                string[] sorok = olvaso.ReadLine().Split(';');
                string szerzo = sorok[0];
                string tartalom = sorok[1];
                Bejegyzes p = new Bejegyzes(szerzo, tartalom);
                lista2.Add(p);
            }
            olvaso.Close();
        }
        public void Veletlenszeru()
        {
            Random rnd = new Random();
            int szamok;
            for (int i = 0; i < lista.Count*20; i++)
            {
                szamok = rnd.Next(0, lista.Count);
                lista[szamok].Like();
            }
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
        }
    }
}
