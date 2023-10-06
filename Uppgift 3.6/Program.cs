using System;
namespace Uppgift3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt förnamn och efternamn.");
            string helanamn = Console.ReadLine();
            int mellanslagIndex = helanamn.IndexOf(" ");
            string förnamn = helanamn[..mellanslagIndex];
            string efternamn = helanamn[(mellanslagIndex + 1)..];

            if (string.Compare(förnamn, efternamn, StringComparison.CurrentCulture) == -1)
            {
                Console.WriteLine("Ditt förnamn kommer först i bokstavsordning.");
            }
            else if (string.Compare(förnamn, efternamn, StringComparison.CurrentCulture) == 0)
            {
                Console.WriteLine("Ditt förnamn och efternamn ligger på samma plats i bokstavs ordning.");
            }
            else if (string.Compare(förnamn, efternamn, StringComparison.CurrentCulture) == 1)
            {
                Console.WriteLine("Ditt efternamn kommer först i bokstavsorndning.");
            }
            Console.ReadKey();
        }
    }
}