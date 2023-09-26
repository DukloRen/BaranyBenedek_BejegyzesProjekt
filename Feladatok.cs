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
        public void Szovegmodositas()
        {
            string ujszoveg;
            Console.WriteLine("Kérem írjon be egy szöveget!");
            ujszoveg = Console.ReadLine();
            lista2[1].Tartalom = ujszoveg;
            for (int i = 0; i < lista2.Count; i++)
            {
                Console.WriteLine(lista2[i].ToString());
            }
        }
        public void Legnepszerubb()                     //melyik listából?
        {
            int max = int.MinValue;
            for (int i = 0; i < lista.Count; i++)
            {
                if (max<lista[i].Likeok)
                {
                    max = lista[i].Likeok;
                }
            }
            Console.WriteLine($"A legnépszerűbb bejegyzés likejainak száma: {max}");
        }
        public void HarmincotLike()
        {
            bool vane = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Likeok>35)
                {
                    vane = true;
                }
            }
            if (vane==true)
            {
                Console.WriteLine("Van olyan bejegyzés ami 35-nél több likeot kapott!");
            }
            else
            {
                Console.WriteLine("Nincs olyan bejegyzés ami 35-nél több likeot kapott!");
            }
        }
        public void KevesebbTizenot()
        {
            int szamlalo = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Likeok < 15)
                {
                    szamlalo++;
                }
            }
            Console.WriteLine($"A 15-nél kevesebb likeot kapott bejegyzések száma: {szamlalo}");
        }
        public void Atrendezes()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[i].Likeok > lista[j].Likeok)
                    {
                        Bejegyzes p = lista[i];
                        lista[i] = lista[j];
                        lista[j] = p;
                    }
                }
            }
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
            StreamWriter iro = new StreamWriter("bejegyzesek_rendezett.txt");
            for (int i = 0; i < lista.Count; i++)
            {
                iro.WriteLine(lista[i].ToString());
            }
            iro.Close();
        }
    }
}
