using System;
class Program {
    static void Main (string[] args) {
        int funcionario = int.Parse(Console.ReadLine());
        int horas = int.Parse(Console.ReadLine());
        double valor = double.Parse(Console.ReadLine());
        double salario = valor * horas;
        Console.WriteLine("NUMBER = " + funcionario);
        Console.WriteLine($"SALARY = U$ {salario:F2}");
    }
}