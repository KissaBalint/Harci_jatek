using System;

namespace Harci_jatek
{
    public static class KarakterKeszito
    {
        public static Harcos UjKarakter()
        {
            Console.WriteLine("=== ÚJ KARAKTER KÉSZÍTÉSE ===");
            Console.Write("Név: ");
            string nev = Console.ReadLine();

            Console.WriteLine("Válassz kasztot:");
            Console.WriteLine("1 - Íjász");
            Console.WriteLine("2 - Katona");
            Console.WriteLine("3 - Pajzsos");
            Console.Write("Választás: ");

            string valasztas = Console.ReadLine();

            Console.Write("HP: ");
            int hp = Convert.ToInt32(Console.ReadLine());

            if (valasztas == "1")
            {
                Console.Write("Nyilak száma: ");
                int nyil = Convert.ToInt32(Console.ReadLine());
                return new Ijasz(nev, hp, nyil);
            }
            else if (valasztas == "2")
            {
                Console.Write("Kard ereje: ");
                int kard = Convert.ToInt32(Console.ReadLine());
                return new Katona(nev, hp, kard);
            }
            else if (valasztas == "3")
            {
                Console.Write("Támadó erő: ");
                int ero = Convert.ToInt32(Console.ReadLine());
                return new Pajzsos(nev, hp, ero);
            }
            else
            {
                Console.WriteLine("Hibás választás! Alap Katona jön létre.");
                return new Katona(nev, 100, 15);
            }
        }
    }
}