namespace Harci_jatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Katona jani = new Katona("János vitéz",100,20);
           

            Ijasz legolasz = new Ijasz("Legolasz",80,10);

           

                Console.WriteLine("=== ÜDVÖZÖLLEK A CSATAMEZŐN! ===");
            Console.WriteLine($"{jani.nev} (HP: {jani.hp}) VS {legolasz.nev} (HP: {legolasz.hp})");

            
            while (jani.hp > 0 && legolasz.hp > 0)
            {
                Console.WriteLine("\nKivel szeretnél támadni?");
                Console.WriteLine("1 - Katona (Karddal vág)");
                Console.WriteLine("2 - Íjász (Nyilat lő)");
                Console.Write("Választásod: ");

                string valasztas = Console.ReadLine();

                Console.WriteLine("------------------------------");

                if (valasztas == "1")
                {
                    Console.Clear();
                    jani.Tamadas(legolasz);
                }
                else if (valasztas == "2")
                {
                    Console.Clear();
                    legolasz.Tamadas(jani);
                }
                else
                {
                    Console.WriteLine("Hibás gomb! A katonák csak néznek egymásra...");
                }

            
                if (jani.hp > 0 && legolasz.hp > 0)
                {
                   
                    Console.WriteLine($"\nÁLLÁS: {jani.nev}: {jani.hp} HP | {legolasz.nev}: {legolasz.hp} HP");
                }
                
            }

          
            Console.WriteLine("\n==============================");
            Console.WriteLine("A CSATA VÉGET ÉRT!");
            if (jani.hp <= 0) Console.WriteLine($"{legolasz.nev} győzött!");
            else Console.WriteLine($"{jani.nev} győzött!");
            Console.WriteLine("==============================");

            Console.ReadKey();
        }

    }
}

