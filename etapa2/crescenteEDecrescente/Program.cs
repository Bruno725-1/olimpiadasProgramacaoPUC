using System;
class Program {
    static void Main (string[] args) {
        while (true) {
            string[] linha = Console.ReadLine().Split(' ');
            int x = int.Parse(linha[0]);
            int y = int.Parse(linha[1]);
            if (x > y)
            Console.WriteLine("Decrescente");
            else if (x < y)
            Console.WriteLine("Crescente");
            else
            break;
        }
    }
}