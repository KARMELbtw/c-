using System;

class Program
{
    static void Main()
    { 
        int a=0;
        int b=0;
        int c=0;

        Console.Write("podaj a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("podaj b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("podaj c: ");
        c = Convert.ToInt32(Console.ReadLine());
        
        int delta = b * b - (4 * (a * c));
        if(delta < 0)
            Console.WriteLine("brak rozwiazan");
        if(delta == 0)
            Console.WriteLine("jedno rozwiazanie");
        if(delta > 0)
            Console.WriteLine("dwa rozwiazania");
    }
}
