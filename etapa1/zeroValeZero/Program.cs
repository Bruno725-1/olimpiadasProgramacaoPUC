using System;
class Program {
    static void Main (string[] args) {
        while (true) {
            string[] entrada = Console.ReadLine().Split(' ');
            if (entrada[0] == "0" && entrada[1] == "0") break;
            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);
            int soma = a + b;
            string novoNumero = RemoverZeros(soma);
            Console.WriteLine(novoNumero);
        }
    }
    static string RemoverZeros(int soma) {
        string primeiro = soma.ToString();
        string novoNumero = "";
        for (int i = 0; i < primeiro.Length; i++) {
            if (primeiro[i] != '0')
            novoNumero += primeiro[i];
        }
        return novoNumero;
    }
}