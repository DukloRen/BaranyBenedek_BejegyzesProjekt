using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BejegyzesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Feladatok p=new Feladatok();
            p.ListaEgy();
            p.Feltoltes();
            p.Veletlenszeru();
            p.Szovegmodositas();
            p.Legnepszerubb();
            p.HarmincotLike();
            p.KevesebbTizenot();
            Console.ReadKey();
        }
    }
}
