using System;
class Program {
    static void Main (string[] args) {
        string nome = Console.ReadLine();
        double fixo = double.Parse(Console.ReadLine());
        double montante = double.Parse(Console.ReadLine());
        double comissao = montante * 0.15;
        double salario = fixo + comissao;
        Console.WriteLine($"TOTAL = R$ {salario:F2}");
    }
}