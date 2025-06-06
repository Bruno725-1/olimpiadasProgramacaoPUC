using System;
class Program {
    static void Main (string[] args) {
        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine());
        double media = distancia / combustivel;
        Console.WriteLine($"{media:F3} km/l");
    }
}