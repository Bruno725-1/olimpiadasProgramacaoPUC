using System;
class Program
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int p1 = int.Parse(entrada[0]);
        int c1 = int.Parse(entrada[1]);
        int p2 = int.Parse(entrada[2]);
        int c2 = int.Parse(entrada[3]);
        int x = p1 * c1;
        int y = p2 * c2;
        if (x == y)
            Console.WriteLine(0);
        else if (x < y)
            Console.WriteLine(1);
        else
            Console.WriteLine(-1);
    }
}