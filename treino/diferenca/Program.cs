﻿using System;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int diferenca = (a * b - c * d);
        Console.WriteLine("DIFERENCA = " + diferenca);
    }
}
