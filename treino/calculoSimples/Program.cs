using System;
class Program {
    static void Main (string[] args) {
        string[]peca1 = Console.ReadLine().Split(' ');
        string[]peca2 = Console.ReadLine().Split(' ');
        double total = (double.Parse(peca1[2]) * int.Parse(peca1[1])) + (double.Parse(peca2[2]) * int.Parse(peca2[1]));
        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
    }
}