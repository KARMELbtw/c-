using System;

class Program
{
    public static int silnia(int n)
    {
        int wynik =1;
        for (int i=1;i<=n;i++)
        {
            wynik=wynik*i;
        }
            return wynik;
    }

    static void Main()
    {
    Console.WriteLine(silnia(5));
    }

}
