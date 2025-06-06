using System;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int d = int.Parse(input[3]);
        int e = int.Parse(input[4]);
        if (EhCrescente(a, b, c, d, e))
            Console.WriteLine("C");
        else if (EhDecrescente(a, b, c, d, e))
            Console.WriteLine("D");
        else
            Console.WriteLine("N");
    }
    static bool EhCrescente(int a, int b, int c, int d, int e)
    {
        return (a < b) && (b < c) && (c < d) && (d < e);
    }
    static bool EhDecrescente(int a, int b, int c, int d, int e)
    {
        return (a > b) && (b > c) && (c > d) && (d > e);
    }
}