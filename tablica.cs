using System.IO;
using System;

    class Program
    {

        static void Main()
        {
            string text = System.IO.File.ReadAllText("tekst.txt");
            Console.Write(text[1]);

            int x = (text[1]);
            int y = (text[2]);

            int[] tab = new int[x];
            tab[y]=text[3];
            Console.Write(tab[y]);
        }
}
