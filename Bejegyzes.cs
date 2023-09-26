﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = DateTime.Now;
            this.szerkesztve = DateTime.Now;
        }

        public string Szerzo { get => szerzo;}
        public string Tartalom { get => tartalom; set => tartalom = value; }
        public int Likeok { get => likeok;}
        public DateTime Letrejott { get => letrejott;}
        public DateTime Szerkesztve { get => szerkesztve;}
        public void Like()
        {
            this.likeok++;
        }
        public override string ToString()
        {
            string tostring = $"{this.szerzo}-{this.likeok}-{this.letrejott}";
            if (this.szerkesztve!=this.letrejott)
            {
                tostring += $"\nSzerkesztve: {this.szerkesztve}";
            }
            tostring += $"\n{this.tartalom}";

            return tostring;
        }
    }
}
