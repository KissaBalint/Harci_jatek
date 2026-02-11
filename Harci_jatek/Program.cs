namespace Harci_jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ÜDVÖZÖLLEK A CSATAMEZŐN! ===");

            Console.WriteLine("1 - Alap karakterek");
            Console.WriteLine("2 - Új karakter készítése");
            Console.Write("Választás: ");
            string kezdes = Console.ReadLine();

            Harcos jatekos;

            if (kezdes == "2")
            {
                Console.Clear();
                jatekos = KarakterKeszito.UjKarakter();
            }
            else
            {
                Console.Clear();
                jatekos = new Katona("János vitéz", 100, 20);
            }

           Harcos ellenfel = new Ijasz("Legolasz", 80, 10);

            Egyseg j1 = (Egyseg)jatekos;
            Egyseg j2 = (Egyseg)ellenfel;

            Console.Clear();
            Console.WriteLine($"{j1.nev} (HP: {j1.hp}) VS {j2.nev} (HP: {j2.hp})");

            while (j1.hp > 0 && j2.hp > 0)
            {
                if(kezdes == "1")
                {
                    Console.WriteLine("\nKivel szeretnél támadni?");
                    Console.WriteLine("1 - János vitéz");
                    Console.WriteLine("2 - Legolasz");
                    Console.Write("Választásod: ");
                }
                else
                {
                    Console.WriteLine("\nKivel szeretnél támadni?");
                    Console.WriteLine("1 - Saját karakter");
                    Console.WriteLine("2 - Ellenfél");
                    Console.Write("Választásod: ");
                }
                

                string valasztas = Console.ReadLine();
                Console.WriteLine("------------------------------");

                if (valasztas == "1")
                {
                    Console.Clear();
                    jatekos.Tamadas(ellenfel);
                }
                else if (valasztas == "2")
                {
                    Console.Clear();
                    ellenfel.Tamadas(jatekos);
                }
                else
                {
                    
                    Console.WriteLine("Hibás választás!");
                }

                Console.WriteLine($"\nÁLLÁS: {j1.nev}: {j1.hp} HP | {j2.nev}: {j2.hp} HP");
            }

            Console.WriteLine("\n==============================");
            Console.WriteLine("A CSATA VÉGET ÉRT!");

            if (j1.hp <= 0)
                Console.WriteLine($"{j2.nev} győzött!");
            else
                Console.WriteLine($"{j1.nev} győzött!");

            Console.WriteLine("==============================");

            Console.ReadKey();
        }

    }
}

