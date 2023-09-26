using System;
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
        private bool szerkesztvex;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = DateTime.Now;
            this.szerkesztve = DateTime.Now;
            this.szerkesztvex = false;
        }

        public string Szerzo { get => szerzo;}
        public string Tartalom{ get => tartalom;
            set
            {
                tartalom = value;
                szerkesztve = DateTime.Now;
                szerkesztvex = true;
            }
        }
        public int Likeok { get => likeok;}
        public DateTime Letrejott { get => letrejott;}
        public DateTime Szerkesztve { get => szerkesztve;}
        public void Like()
        {
            this.likeok++;
        }
        public override string ToString()
        {
            string tostring = $"\n{this.szerzo}-{this.likeok}-{this.letrejott}";
            if (this.szerkesztvex==true)
            {
                tostring += $"\nSzerkesztve: {this.szerkesztve}";
            }
            tostring += $"\n{this.tartalom}";

            return tostring;
        }
    }
}
