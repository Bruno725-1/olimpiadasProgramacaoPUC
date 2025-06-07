using System;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int v = int.Parse(input[0]);
        int n = int.Parse(input[1]);
        int total = v * n;
    }
}