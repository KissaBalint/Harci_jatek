using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harci_jatek
{
    public class Ijasz : Egyseg, Harcos
    {
        public int nyildb;

        public Ijasz(string nev, int hp, int nyildb) : base(nev, hp)
        {
            this.nyildb = nyildb;
        }

        public void Tamadas(Harcos celpont)
        {
            if(nyildb > 0)
            {
                Console.WriteLine($"{nev} kilő egy nyílvesszőt!");
                nyildb--;
                celpont.Sebzodes(15);
            }
            else
            {
                Console.WriteLine($"{nev} kifogyott a nyilakból!");
            }
        }

        public void sebzodes(int ero)
        {
            hp -= ero;
            Console.WriteLine($"{nev} próbálta kikerülni, de így is kapott {ero} sebzést, maradék HP: {hp}");
        }
        void Harcos.Sebzodes(int ero)
        {
            sebzodes(ero);
        }

    }
}
