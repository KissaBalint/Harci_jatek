using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harci_jatek
{
    public abstract class Egyseg
    {
        public string nev;
        public int hp;

        protected Egyseg(string nev, int hp)
        {
            this.nev = nev;
            this.hp = hp;
        }

        public void meghaltE()
        {
            if(hp <= 0)
            {
                Console.WriteLine($"{nev} meghalt.");
            }
        }
    }
}
