using System;

namespace Harci_jatek
{
    public class Pajzsos : Egyseg, Harcos
    {
        public int ero;

        public Pajzsos(string nev, int hp, int ero) : base(nev, hp)
        {
            this.ero = ero;
        }

        public void Tamadas(Harcos celpont)
        {
            int sebzes = ero;

            if (sebzes > 15)
            {
                sebzes = 15;
            }

            Console.WriteLine($"{nev} pajzzsal támad!");
            celpont.Sebzodes(sebzes);
        }

        public void Sebzodes(int ero)
        {
            int kapott = ero / 2;
            hp -= kapott;

            Console.WriteLine($"{nev} pajzzsal védekezett, csak {kapott} sebzést kapott. Maradék HP: {hp}");
            meghaltE();
        }
    }
}