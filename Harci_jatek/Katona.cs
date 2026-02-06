using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harci_jatek
{
    public class Katona : Egyseg, Harcos
    {
        public int kardEro;

        public Katona(string nev, int hp, int kardEro) : base(nev, hp)
        {
            this.kardEro = kardEro;
        }


        public void Tamadas(Harcos celpont)
        {
            Console.WriteLine($"{nev} támad kardjával");
            celpont.Sebzodes(kardEro);
        }

        public void Sebzodes(int ero)
        {
            hp -= ero;
            Console.WriteLine($"{nev} sebződött {ero} pontot, maradek HP: {hp}");
            meghaltE();
        }

    }
}
