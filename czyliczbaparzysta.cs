using System;
namespace czyliczbaparzysta
{
    
}
class Program
{
    static void Main()
    {
        int liczba =0;
        while (liczba != 420)
        {
            Console.WriteLine("Podaj liczbę do sprawdzenia: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nie parzysta");
            }
        }
    }
}
