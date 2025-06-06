using System;
class Program {
    static void Main (string[] args) {
        int n = int.Parse(Console.ReadLine());
        string[] linha2 = Console.ReadLine().Split(' ');
        int p = int.Parse(linha2[0]);
        char operador = char.Parse(linha2[1]);
        int q = int.Parse(linha2[2]);
        int resultado = 0;
        switch (operador) {
            case '+':
            resultado = p + q;
            break;
            case '*':
            resultado = p * q;
            break;
        }
        if (resultado > n)
        Console.WriteLine("OVERFLOW");
        else
        Console.WriteLine("OK");
    }
}