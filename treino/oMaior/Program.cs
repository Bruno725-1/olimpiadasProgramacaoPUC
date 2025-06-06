using System;
class Program {
    static void Main(string[] args) {
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int ab = (a + b + Math.Abs(a - b)) / 2;
        if (ab > c)
        Console.WriteLine(ab + " eh o maior");
        else
        Console.WriteLine(c + " eh o maior");
    }
}